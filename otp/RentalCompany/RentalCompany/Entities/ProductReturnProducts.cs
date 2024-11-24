namespace RentalCompany.Entities;

public class ProductReturnProducts
{
    public int Id { get; private set; }

    public int ProductId { get; private set; }

    public int ProductReturnId { get; private set; }

    public static ProductReturnProducts CreateElement(int id, int productId, int productReturnId)
    {
        return new ProductReturnProducts
        {
            Id = id,
            ProductId = productId,
            ProductReturnId = productReturnId,
        };
    }
}
