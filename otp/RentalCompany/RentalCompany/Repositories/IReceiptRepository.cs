using RentalCompany.Entities;

namespace RentalCompany.Repositories;

public interface IReceiptRepository
{
    IEnumerable<Receipt> ReadReceipts(
        DateTime? dateForm = null,
        DateTime? dateTo = null,
        int? clientId = null,
        int? sellerId = null
    );

    Receipt ReadReceiptById(int id);

    void CreateReceipt(Receipt receipt);

    void DeleteReceipt(int id);
}
