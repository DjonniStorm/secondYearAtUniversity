using RentalCompany.Entities.Enums;

namespace RentalCompany.Entities;

public class Seller
{
    public int Id { get; private set; }

    public string Name { get; private set; } = string.Empty;

    public string Surname { get; private set; } = string.Empty;

    public int WorkExperience { get; private set; }

    public string Phone { get; private set; } = string.Empty;

    public string Email { get; private set; } = string.Empty;

    public SellerType Type { get; private set; }

    public static Seller CreateEntity(
        int id,
        string name,
        string surname,
        int workExperience,
        string phone,
        string email,
        SellerType sellerType
    )
    {
        return new Seller
        {
            Id = id,
            Name = name,
            Surname = surname,
            WorkExperience = workExperience,
            Phone = phone,
            Email = email,
            Type = sellerType,
        };
    }
}
