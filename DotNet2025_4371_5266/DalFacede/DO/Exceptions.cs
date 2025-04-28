namespace DO;

/// <summary>
/// חריגה עבור מזהה שלא נמצא
/// </summary>
[Serializable]
public class dal_idNotFound : Exception
{
    public dal_idNotFound(string? message) : base(message) { }
}

/// <summary>
/// חריגה עבור מזהה שכבר קיים
/// </summary>
[Serializable]
public class dal_idExist : Exception
{
    public dal_idExist(string? message) : base(message) { }
}

/// <summary>
/// חריגה עבור אובייקט שלא נמצא
/// </summary>
[Serializable]
public class dal_objcectNotFound : Exception
{
    public dal_objcectNotFound(string? message) : base(message) { }
}

/// <summary>
/// חריגה עבור תפריט לא חוקי
/// </summary>
[Serializable]
public class dal_InvalidMenu : Exception
{
    public dal_InvalidMenu(string? message) : base(message) { }
}



