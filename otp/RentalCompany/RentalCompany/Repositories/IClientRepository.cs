using RentalCompany.Entities;

namespace RentalCompany.Repositories;

public interface IClientRepository
{
    IEnumerable<Client> ReadClients();

    Client ReadClientById(int id);

    void CreateClient(Client client);

    void UpdateClient(Client client);

    void DeleteClient(int clientId);
}
