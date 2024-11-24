using RentalCompany.Entities;
using RentalCompany.Repositories;

namespace RentalCompany.Forms;

public partial class FormClient : Form
{
    private readonly IClientRepository _clientRepository;
    private int? _clientId;
    public int Id
    {
        set
        {
            try
            {
                var client = _clientRepository.ReadClientById(value);
                if (client == null)
                {
                    throw new InvalidDataException(nameof(client));
                }
                textBoxClientName.Text = client.Name;
                textBoxClientSurname.Text = client.Surname;
                textBoxClientPhone.Text = client.Phone;
                numericUpDownLoayltyPoints.Value = client.LoyaltyPoint;
                dateTimePickerDateOfBirth.Value = client.DateOfBirth ?? dateTimePickerDateOfBirth.MinDate;
                _clientId = value;
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    ex.Message,
                    "Ошибка при получении данных",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                );
                return;
            }
        }
    }

    public FormClient(IClientRepository clientRepository)
    {
        InitializeComponent();

        _clientRepository =
            clientRepository ?? throw new ArgumentNullException(nameof(clientRepository));
    }

    private void ButtonSave_Click(object sender, EventArgs e)
    {
        try
        {
            if (
                string.IsNullOrWhiteSpace(textBoxClientName.Text)
                || string.IsNullOrWhiteSpace(textBoxClientSurname.Text)
                || string.IsNullOrWhiteSpace(textBoxClientPhone.Text)
            )
            {
                throw new Exception("Имеются незаполненные поля");
            }

            if (_clientId.HasValue)
            {
                _clientRepository.UpdateClient(CreateClient(_clientId.Value));
            }
            else
            {
                _clientRepository.CreateClient(CreateClient(0));
            }

            Close();
        }
        catch (Exception ex)
        {
            MessageBox.Show(
                ex.Message,
                "Ошибка при сохранении",
                MessageBoxButtons.OK,
                MessageBoxIcon.Error
            );
        }
    }

    private Client CreateClient(int clientId) =>
        Client.CreateEntity(
            id: clientId,
            name: textBoxClientName.Text,
            surname: textBoxClientSurname.Text,
            phone: textBoxClientPhone.Text,
            dateOfBirth: dateTimePickerDateOfBirth.Value
        );

    private void ButtonCancel_Click(object sender, EventArgs e) => Close();
}
