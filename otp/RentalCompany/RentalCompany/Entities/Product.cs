using RentalCompany.Entities.Enums;

namespace RentalCompany.Entities;

public class Product
{
    public int Id { get; private set; }

    public string Name { get; private set; } = string.Empty;

    public string Description { get; private set; } = string.Empty;

    public decimal Price { get; private set; }

    public int Total { get; private set; }

    public byte AgeLimit { get; private set; }

    public string Genre { get; private set; } = string.Empty;

    public ProductType ProductType { get; private set; } = ProductType.None;

    public static Product CreateEntity(
        int id,
        string name,
        string description,
        decimal price,
        int total,
        byte ageLimit,
        string genre,
        ProductType productType
    )
    {
        return new Product
        {
            Id = id,
            Name = name ?? string.Empty,
            Description = description ?? string.Empty,
            Price = price,
            Total = total,
            AgeLimit = ageLimit,
            Genre = genre ?? string.Empty,
            ProductType = productType,
        };
    }
}
