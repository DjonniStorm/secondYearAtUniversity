namespace RentalCompany.Entities;

public class ProductReturn
{
    public int Id { get; private set; }

    public int ClientId { get; private set; }

    public DateTime DateTime { get; private set; }

    public decimal Fine { get; private set; } = 0;

    public IEnumerable<ProductReturnProducts> Products { get; private set; } = [];

    public static ProductReturn CreateOperation(
        int id,
        int clientId,
        decimal fine,
        IEnumerable<ProductReturnProducts> products
    )
    {
        return new ProductReturn
        {
            Id = id,
            ClientId = clientId,
            DateTime = DateTime.Now,
            Fine = fine,
            Products = products,
        };
    }
}
