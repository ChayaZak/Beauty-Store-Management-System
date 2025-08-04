namespace DO;


[Serializable]
public record Sale(int Code, int ProductId, int MinQuantity, double Price, bool InClab, DateTime BeginSale, DateTime EndSale)
{
    public Sale() : this(0, 0, 20, 50, false, DateTime.Now, DateTime.Now)
    {

    }
}


