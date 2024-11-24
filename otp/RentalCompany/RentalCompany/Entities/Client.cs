namespace RentalCompany.Entities;

public class Client
{
    public int Id { get; private set; }

    public string Name { get; private set; } = string.Empty;

    public string Surname { get; private set; } = string.Empty;

    public string Phone { get; private set; } = string.Empty;

    public int LoyaltyPoint { get; private set; } = 0;

    public DateTime DateOfRegistration { get; private set; }

    public DateTime? DateOfBirth { get; private set; }

    public static Client CreateEntity(
        int id,
        string name,
        string surname,
        string phone,
        DateTime? dateOfBirth
    )
    {
        return new Client
        {
            Id = id,
            Name = name ?? string.Empty,
            Surname = surname ?? string.Empty,
            Phone = phone ?? string.Empty,
            DateOfRegistration = DateTime.Now,
            DateOfBirth = dateOfBirth,
        };
    }
}
