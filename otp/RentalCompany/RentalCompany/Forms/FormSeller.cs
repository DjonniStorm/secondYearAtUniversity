using RentalCompany.Entities;
using RentalCompany.Entities.Enums;
using RentalCompany.Repositories;

namespace RentalCompany.Forms;

public partial class FormSeller : Form
{
    private readonly ISellerRepository _sellerRepository;
    private int? _sellerId;

    public int Id
    {
        set
        {
            try
            {
                var seller = _sellerRepository.ReadSellerById(value);
                if (seller == null)
                {
                    throw new InvalidDataException(nameof(seller));
                }

                foreach (SellerType item in Enum.GetValues(typeof(SellerType)))
                {
                    if ((item & seller.Type) != 0)
                    {
                        checkedListBoxType.SetItemChecked(
                            checkedListBoxType.Items.IndexOf(item),
                            true
                        );
                    }
                }

                textBoxSellerName.Text = seller.Name;
                textBoxSellerSurname.Text = seller.Surname;
                numericUpDownSellerWorkExp.Value = seller.WorkExperience;
                textBoxSellerPhone.Text = seller.Phone;
                textBoxSellerEmail.Text = seller.Email;

                _sellerId = value;
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

    public FormSeller(ISellerRepository sellerRepository)
    {
        InitializeComponent();

        _sellerRepository =
            sellerRepository ?? throw new ArgumentNullException(nameof(sellerRepository));

        foreach (SellerType item in Enum.GetValues(typeof(SellerType)))
        {
            checkedListBoxType.Items.Add(item);
        }
    }

    private void ButtonSave_Click(object sender, EventArgs e)
    {
        try
        {
            if (
                string.IsNullOrWhiteSpace(textBoxSellerName.Text)
                || string.IsNullOrWhiteSpace(textBoxSellerSurname.Text)
                || string.IsNullOrWhiteSpace(textBoxSellerEmail.Text)
                || string.IsNullOrWhiteSpace(textBoxSellerPhone.Text)
            )
            {
                throw new Exception("Имеются незаполненные поля");
            }

            if (_sellerId.HasValue)
            {
                _sellerRepository.UpdateSeller(CreateSeller(_sellerId.Value));
            }
            else
            {
                _sellerRepository.CreateSeller(CreateSeller(0));
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

    private void ButtonCancel_Click(object sender, EventArgs e) => Close();

    private Seller CreateSeller(int sellerId)
    {
        SellerType sellerType = SellerType.Сashier;
        foreach (var item in checkedListBoxType.Items)
        {
            sellerType |= (SellerType)item;
        }

        return Seller.CreateEntity(
            id: sellerId,
            name: textBoxSellerName.Text,
            surname: textBoxSellerSurname.Text,
            workExperience: (int)numericUpDownSellerWorkExp.Value,
            phone: textBoxSellerPhone.Text,
            email: textBoxSellerEmail.Text,
            sellerType: sellerType
        );
    }
}
