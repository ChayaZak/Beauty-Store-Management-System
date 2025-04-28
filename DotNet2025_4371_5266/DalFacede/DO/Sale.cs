namespace DO;

/// <summary>
/// תכונות של מבצע
/// </summary>
/// <param name="Code">קוד המבצע</param>
/// <param name="ProductId">מזהה המוצר</param>
/// <param name="MinQuantity">כמות מינימלית</param>
/// <param name="Price">מחיר המבצע</param>
/// <param name="InClab">האם המבצע מיועד ללקוחות מועדון בלבד</param>
/// <param name="BeginSale">תאריך התחלת המבצע</param>
/// <param name="EndSale">תאריך סיום המבצע</param>
public record Sale(int Code, int ProductId, int MinQuantity, double Price, bool InClab, DateTime BeginSale, DateTime EndSale)
{
    public Sale() : this(0, 0, 20, 50, false, DateTime.Now, DateTime.Now)
    {

    }
}


