namespace RentalCompany.Entities;

public class ReceiptLine
{
    public int ProductId { get; private set; }

    public int ReceiptId { get; private set; }

    public int RentalTime { get; private set; }

    public static ReceiptLine CreateElement(int productId, int receiptId, int rentalTime)
    {
        return new ReceiptLine
        {
            ProductId = productId,
            ReceiptId = receiptId,
            RentalTime = rentalTime,
        };
    }
}
