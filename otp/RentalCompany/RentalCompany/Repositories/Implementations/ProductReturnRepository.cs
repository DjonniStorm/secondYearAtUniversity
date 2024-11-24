using RentalCompany.Entities;

namespace RentalCompany.Repositories.Implementations;

public class ProductReturnRepository : IProductReturnRepository
{
    public void CreateProductReturn(ProductReturn productReturn) { }

    public void DeleteProductReturn(int id) { }

    public IEnumerable<ProductReturn> ReadProductsReturns(
        int? clientId = null,
        DateTime? dateForm = null,
        DateTime? dateTo = null
    ) => [];
}
