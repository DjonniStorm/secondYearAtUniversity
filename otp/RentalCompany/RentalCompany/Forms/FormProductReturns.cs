using RentalCompany.Repositories;
using Unity;

namespace RentalCompany.Forms;

public partial class FormProductReturns : Form
{
    private readonly IUnityContainer _container;

    private readonly IProductReturnRepository _productReturnRepository;

    public FormProductReturns(
        IUnityContainer container,
        IProductReturnRepository productReturnRepository
    )
    {
        InitializeComponent();
        _container = container ?? throw new ArgumentNullException(nameof(container));
        _productReturnRepository =
            productReturnRepository
            ?? throw new ArgumentNullException(nameof(productReturnRepository));
    }

    private void FormProductReturns_Load(object sender, EventArgs e)
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
            _container.Resolve<FormProductReturn>().ShowDialog();
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
            _productReturnRepository.DeleteProductReturn(findId);
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

    private void LoadList() =>
        dataGridViewData.DataSource = _productReturnRepository.ReadProductsReturns();
}
