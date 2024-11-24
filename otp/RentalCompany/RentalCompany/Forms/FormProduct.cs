using RentalCompany.Entities;
using RentalCompany.Entities.Enums;
using RentalCompany.Repositories;

namespace RentalCompany.Forms;

public partial class FormProduct : Form
{
    private readonly IProductRepository _productRepository;
    private int? _productId;

    public FormProduct(IProductRepository productRepository)
    {
        InitializeComponent();
        _productRepository =
            productRepository ?? throw new ArgumentNullException(nameof(productRepository));
        comboBoxProductType.DataSource = Enum.GetValues(typeof(ProductType));
    }

    public int Id
    {
        set
        {
            try
            {
                var product = _productRepository.ReadProductById(value);
                MessageBox.Show(value.ToString());
                if (product == null)
                {
                    throw new InvalidDataException(nameof(product));
                }
                textBoxName.Text = product.Name;
                richTextBoxDescription.Text = product.Description;
                numericUpDownPrice.Value = product.Price;
                numericUpDownTotal.Value = product.Total;
                numericUpDownAgeLimit.Value = product.AgeLimit;
                textBoxProductGenre.Text = product.Genre;
                comboBoxProductType.SelectedItem = product.ProductType;
                MessageBox.Show(product.ProductType.ToString());

                _productId = value;
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

    private void ButtonSave_Click(object sender, EventArgs e)
    {
        try
        {
            if (
                string.IsNullOrWhiteSpace(textBoxName.Text)
                || string.IsNullOrWhiteSpace(richTextBoxDescription.Text)
                || string.IsNullOrWhiteSpace(textBoxProductGenre.Text)
                || Enum.Equals(comboBoxProductType.SelectedItem, ProductType.None)
            )
            {
                throw new Exception("Имеются незаполненные поля");
            }

            if (_productId.HasValue)
            {
                _productRepository.UpdateProduct(CreateProduct(_productId.Value));
            }
            else
            {
                _productRepository.CreateProduct(CreateProduct(0));
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

    private Product CreateProduct(int productId) =>
        Product.CreateEntity(
            id: productId,
            name: textBoxName.Text,
            description: richTextBoxDescription.Text,
            price: numericUpDownPrice.Value,
            total: (int)numericUpDownTotal.Value,
            ageLimit: (byte)numericUpDownAgeLimit.Value,
            genre: textBoxProductGenre.Text,
            productType: (ProductType)comboBoxProductType.SelectedItem!
        );

    private void ButtonCancel_Click(object sender, EventArgs e) => Close();
}
