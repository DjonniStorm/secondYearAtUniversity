using RentalCompany.Entities;
using RentalCompany.Repositories;

namespace RentalCompany.Forms;

public partial class FormReceipt : Form
{
    private readonly IReceiptRepository _receiptRepository;

    public FormReceipt(
        IReceiptRepository receiptRepository,
        IProductRepository productRepository,
        ISellerRepository sellerRepository,
        IClientRepository clientRepository
    )
    {
        InitializeComponent();
        _receiptRepository =
            receiptRepository ?? throw new ArgumentNullException(nameof(receiptRepository));

        comboBoxClients.DataSource = clientRepository.ReadClients();
        comboBoxClients.DisplayMember = "Name";
        comboBoxClients.ValueMember = "Id";

        comboBoxSellers.DataSource = sellerRepository.ReadSellers();
        comboBoxSellers.DisplayMember = "Name";
        comboBoxSellers.ValueMember = "Id";

        columnProduct.DataSource = productRepository.ReadProducts();
        columnProduct.DisplayMember = "Name";
        columnProduct.ValueMember = "Id";
    }

    private void ButtonSave_Click(object sender, EventArgs e)
    {
        try
        {
            if (
                dataGridViewData.RowCount < 1
                || comboBoxClients.SelectedIndex < 0
                || comboBoxSellers.SelectedIndex < 0
            )
            {
                throw new Exception("Имеются незаполненные поля");
            }
            _receiptRepository.CreateReceipt(
                Receipt.CreateOperation(
                    id: 0,
                    clientId: (int)comboBoxClients.SelectedValue!,
                    sellerId: (int)comboBoxSellers.SelectedValue!,
                    discount: (float)numericUpDownDiscount.Value,
                    totalPrice: numericUpDownTotal.Value,
                    receiptLines: CreateListFeedFeedReplenishmentsFromDataGrid()
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

    private List<ReceiptLine> CreateListReceiptsFromDataGrid()
    {
        var list = new List<ReceiptLine>();
        foreach (DataGridViewRow row in dataGridViewData.Rows)
        {
            if (row.Cells["ColumnFeed"].Value == null || row.Cells["ColumnCount"].Value == null)
            {
                continue;
            }

            list.Add(
                ReceiptLine.CreateElement(
                    productId: Convert.ToInt32(row.Cells["columnProduct"].Value),
                    receiptId: 0,
                    rentalTime: Convert.ToInt32(row.Cells["ColumnRentalTime"].Value)
                )
            );
        }

        return list;
    }

    private void ButtonCancel_Click(object sender, EventArgs e) => Close();
}
