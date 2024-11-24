using RentalCompany.Entities;

namespace RentalCompany.Repositories;

public interface ISellerRepository
{
    IEnumerable<Seller> ReadSellers();

    Seller ReadSellerById(int id);

    void CreateSeller(Seller seller);

    void UpdateSeller(Seller seller);

    void DeleteSeller(int id);
}
