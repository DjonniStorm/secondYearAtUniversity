using RentalCompany.Entities;

namespace RentalCompany.Repositories.Implementations;

public class ReceiptRepository : IReceiptRepository
{
    public void CreateReceipt(Receipt receipt) { }

    public void DeleteReceipt(int id) { }

    public Receipt ReadReceiptById(int id) =>
        Receipt.CreateOperation(
            id: id,
            clientId: 0,
            sellerId: 0,
            discount: 0f,
            totalPrice: 0,
            receiptLines: []
        );

    public IEnumerable<Receipt> ReadReceipts(
        DateTime? dateForm = null,
        DateTime? dateTo = null,
        int? clientId = null,
        int? sellerId = null
    ) => [];
}
