using RentalCompany.Entities;

namespace RentalCompany.Repositories.Implementations;

public class ProductRepository : IProductRepository
{
    public void CreateProduct(Product product) { }

    public void DeleteProduct(int id) { }

    public Product ReadProductById(int id) =>
        Product.CreateEntity(
            id: id,
            name: "Гарри Поттер",
            description: null,
            price: 200,
            total: 40,
            genre: "Фантастика",
            ageLimit: 12,
            productType: Entities.Enums.ProductType.Video
        );

    public IEnumerable<Product> ReadProducts() => [];

    public void UpdateProduct(Product product) { }
}
