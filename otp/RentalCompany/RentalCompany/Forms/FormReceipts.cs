using RentalCompany.Repositories;
using Unity;

namespace RentalCompany.Forms;

public partial class FormReceipts : Form
{
    private readonly IUnityContainer _container;

    private readonly IReceiptRepository _receiptRepository;

    public FormReceipts(IUnityContainer container, IReceiptRepository receiptRepository)
    {
        InitializeComponent();
        _container = container ?? throw new ArgumentNullException(nameof(container));
        _receiptRepository =
            receiptRepository ?? throw new ArgumentNullException(nameof(receiptRepository));
    }

    private void FormReceipts_Load(object sender, EventArgs e)
    {
        try
        {
            LoadList();
        }
        catch (Exception ex)
        {
            MessageBox.Show(
                ex.Message,
                "Ошибка при загрузке",
                MessageBoxButtons.OK,
                MessageBoxIcon.Error
            );
        }
    }

    private void ButtonAdd_Click(object sender, EventArgs e)
    {
        try
        {
            _container.Resolve<FormReceipt>().ShowDialog();
            LoadList();
        }
        catch (Exception ex)
        {
            MessageBox.Show(
                ex.Message,
                "Ошибка при добавлении",
                MessageBoxButtons.OK,
                MessageBoxIcon.Error
            );
        }
    }

    private void ButtonDel_Click(object sender, EventArgs e)
    {
        if (!TryGetIdentifierFromSelectedRow(out var findId))
        {
            return;
        }

        if (
            MessageBox.Show("Удалить запись?", "Удаление", MessageBoxButtons.YesNo)
            != DialogResult.Yes
        )
        {
            return;
        }

        try
        {
            _receiptRepository.DeleteReceipt(findId);
            LoadList();
        }
        catch (Exception ex)
        {
            MessageBox.Show(
                ex.Message,
                "Ошибка при удалении",
                MessageBoxButtons.OK,
                MessageBoxIcon.Error
            );
        }
    }

    private bool TryGetIdentifierFromSelectedRow(out int id)
    {
        id = 0;
        if (dataGridViewData.SelectedRows.Count < 1)
        {
            MessageBox.Show(
                "Нет выбранной записи",
                "Ошибка",
                MessageBoxButtons.OK,
                MessageBoxIcon.Error
            );
            return false;
        }

        id = Convert.ToInt32(dataGridViewData.SelectedRows[0].Cells["Id"].Value);
        return true;
    }

    private void LoadList() => dataGridViewData.DataSource = _receiptRepository.ReadReceipts();
}
