namespace RentalCompany.Entities;

public class Receipt
{
    public int Id { get; private set; }

    public int ClientId { get; private set; }

    public int SellerId { get; private set; }

    public DateTime DateReceipt { get; private set; }

    public float Discount { get; private set; } = 0;

    public decimal TotalPrice { get; private set; }

    public IEnumerable<ReceiptLine> ReceiptLines { get; private set; } = [];

    public static Receipt CreateOperation(
        int id,
        int clientId,
        int sellerId,
        float discount,
        decimal totalPrice,
        IEnumerable<ReceiptLine> receiptLines
    )
    {
        return new Receipt
        {
            Id = id,
            ClientId = clientId,
            SellerId = sellerId,
            DateReceipt = DateTime.Now,
            Discount = discount,
            TotalPrice = totalPrice,
            ReceiptLines = receiptLines,
        };
    }
}
