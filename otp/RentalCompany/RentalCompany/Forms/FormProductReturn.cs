using RentalCompany.Entities;
using RentalCompany.Repositories;

namespace RentalCompany.Forms;

public partial class FormProductReturn : Form
{
    private readonly IProductReturnRepository _productReturnRepository;

    public FormProductReturn(
        IProductReturnRepository productReturnRepository,
        IClientRepository clientRepository,
        IProductRepository productRepository,
        IReceiptRepository receiptRepository
    )
    {
        InitializeComponent();

        _productReturnRepository =
            productReturnRepository
            ?? throw new ArgumentNullException(nameof(productReturnRepository));

        comboBoxClients.DataSource = clientRepository.ReadClients();
        comboBoxClients.DisplayMember = "Name";
        comboBoxClients.ValueMember = "Id";

        var client = clientRepository.ReadClientById(0);

        var clientItems = receiptRepository
            .ReadReceipts()
            .Where(receipt => receipt.ClientId == client.Id)
            .SelectMany(receipt =>
                receipt.ReceiptLines.Select(line =>
                    productRepository.ReadProductById(line.ProductId)
                )
            )
            .ToList();

        ColumnProduct.DataSource = clientItems;
        ColumnProduct.DisplayMember = "Name";
        ColumnProduct.ValueMember = "Id";

        int clientFine = receiptRepository
            .ReadReceipts()
            .Where(receipt => receipt.ClientId == client.Id)
            .SelectMany(
                receipt =>
                    receipt.ReceiptLines.Where(line =>
                        (DateTime.Now - receipt.DateReceipt).Days > line.RentalTime
                    ),
                (receipt, line) => new { receipt, line }
            )
            .Sum(receiptAndLine => ((DateTime.Now - receiptAndLine.receipt.DateReceipt).Days - receiptAndLine.line.RentalTime) * 50); // сумма штрафа

        numericUpDownFine.Value = clientFine;
    }

    private void ButtonSave_Click(object sender, EventArgs e)
    {
        try
        {
            if (dataGridViewData.RowCount < 1 || comboBoxClients.SelectedIndex < 0)
            {
                throw new Exception("Имеются незаполненные поля");
            }
            _productReturnRepository.CreateProductReturn(
                ProductReturn.CreateOperation(
                    id: 0,
                    clientId: (int)comboBoxClients.SelectedValue!,
                    fine: 10,
                    products: CreateListProductReturnsFromDataGrid()
                )
            );

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

    private List<ProductReturnProducts> CreateListProductReturnsFromDataGrid()
    {
        var list = new List<ProductReturnProducts>();
        foreach (DataGridViewRow row in dataGridViewData.Rows)
        {
            if (row.Cells["ColumnReturn"].Value == null || row.Cells["ColumnCount"].Value == null)
            {
                continue;
            }

            if (bool.Parse(row.Cells["ColumnReturn"].Value.ToString() ?? string.Empty))
            {
                list.Add(
                    ProductReturnProducts.CreateElement(
                        id: 0,
                        productId: Convert.ToInt32(row.Cells["ColumnProduct"].Value),
                        productReturnId: 0
                    )
                );
            }
        }

        return list;
    }

    private void ButtonCancel_Click(object sender, EventArgs e) => Close();
}
