using static DalApi.DalConfig;
namespace DalApi;
using System.Reflection;
using System.IO;


public static class Factory
{

    public static IDal Get
    {
        get
        {

            string dalType = s_dalName ?? throw new DalConfigException($"DAL name is not extracted from the configuration");
            string dal = s_dalPackages[dalType] ?? throw new DalConfigException($"Package for {dalType} is not found in packages list in dal-config.xml");
            string dalDllPath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "DalTest.dll");

            try
            {
                Assembly.LoadFrom(dalDllPath);
            }
            catch (FileNotFoundException ex)
            {
                throw new DalConfigException($"The DLL {dal}.dll could not be found on the system.", ex);
            }
            catch (BadImageFormatException ex)
            {
                throw new DalConfigException($"The DLL {dal}.dll is not a valid assembly.", ex);
            }
            catch (Exception ex)
            {
                throw new DalConfigException($"Failed to load {dal}.dll package", ex);
            }



            Type type = Type.GetType($"Dal.{dal}, {dal}") ??
                    throw new DalConfigException($"Class Dal.{dal} was not found in {dal}.dll");

            return type.GetProperty("Instance", BindingFlags.Public | BindingFlags.Static)?.GetValue(null) as IDal ??
                throw new DalConfigException($"Class {dal} is not a singleton or wrong property name for Instance");
        }
    }
}

