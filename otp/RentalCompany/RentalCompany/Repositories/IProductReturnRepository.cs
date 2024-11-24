using RentalCompany.Entities;

namespace RentalCompany.Repositories;

public interface IProductReturnRepository
{
    IEnumerable<ProductReturn> ReadProductsReturns(
        int? clientId = null,
        DateTime? dateForm = null,
        DateTime? dateTo = null
    );

    void CreateProductReturn(ProductReturn productReturn);

    void DeleteProductReturn(int id);
}
