using RentalCompany.Entities;

namespace RentalCompany.Repositories.Implementations;

internal class SellerRepository : ISellerRepository
{
    public void CreateSeller(Seller seller) { }

    public void DeleteSeller(int id) { }

    public IEnumerable<Seller> ReadSellers()
    {
        return [];
    }

    public Seller ReadSellerById(int id)
    {
        return Seller.CreateEntity(
            id: id,
            name: string.Empty,
            surname: string.Empty,
            workExperience: 0,
            phone: string.Empty,
            email: string.Empty,
            sellerType: Entities.Enums.SellerType.Intern
        );
    }

    public void UpdateSeller(Seller seller) { }
}
