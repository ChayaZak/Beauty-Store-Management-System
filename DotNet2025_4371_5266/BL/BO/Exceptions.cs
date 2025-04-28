namespace BO;

/// <summary>
/// חריגה עבור אובייקט null
/// </summary>
[Serializable]
public class Bl_ObjectIsNull : Exception
{
    public Bl_ObjectIsNull(string? message) : base(message) { }
    public Bl_ObjectIsNull(string? message, Exception? innerException) : base(message, innerException) { }
}

/// <summary>
/// חריגה עבור מזהה שלא נמצא
/// </summary>
[Serializable]
public class Bl_IdNotFound : Exception
{
    public Bl_IdNotFound(string? message) : base(message) { }
    public Bl_IdNotFound(string? message, Exception? innerException) : base(message, innerException) { }
}

/// <summary>
/// חריגה עבור מזהה שכבר קיים
/// </summary>
[Serializable]
public class Bl_IdExist : Exception
{
    public Bl_IdExist(string? message) : base(message) { }
    public Bl_IdExist(string? message, Exception? innerException) : base(message, innerException) { }
}

/// <summary>
/// חריגה עבור שגיאה פנימית
/// </summary>
[Serializable]
public class Bl_InternalError : Exception
{
    public Bl_InternalError(string? message) : base(message) { }
    public Bl_InternalError(string? message, Exception? innerException) : base(message, innerException) { }
}

/// <summary>
/// חריגה עבור קלט לא תקין
/// </summary>
[Serializable]
public class Bl_InvalidInput : Exception
{
    public Bl_InvalidInput(string? message) : base(message) { }
    public Bl_InvalidInput(string? message, Exception? innerException) : base(message, innerException) { }
}


