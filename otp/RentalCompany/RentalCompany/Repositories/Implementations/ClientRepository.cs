using RentalCompany.Entities;

namespace RentalCompany.Repositories.Implementations;

public class ClientRepository : IClientRepository
{
    public void CreateClient(Client client) { }

    public void DeleteClient(int clientId) { }

    public Client ReadClientById(int id)
    {
        return Client.CreateEntity(
            id: id,
            name: string.Empty,
            surname: string.Empty,
            phone: string.Empty,
            dateOfBirth: DateTime.Now
        );
    }

    public IEnumerable<Client> ReadClients() => [];

    public void UpdateClient(Client client) { }
}
