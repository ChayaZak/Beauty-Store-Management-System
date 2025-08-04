namespace DO;


[Serializable]
public class dal_idNotFound : Exception
{
    public dal_idNotFound(string? message) : base(message) { }
}


public class dal_idExist : Exception
{
    public dal_idExist(string? message) : base(message) { }
}


[Serializable]
public class dal_objcectNotFound : Exception
{
    public dal_objcectNotFound(string? message) : base(message) { }
}


[Serializable]
public class dal_InvalidMenu : Exception
{
    public dal_InvalidMenu(string? message) : base(message) { }
}


[Serializable]
public class dal_XmlFileLoad : Exception
{
    public dal_XmlFileLoad(string? message) : base(message) { }
}



