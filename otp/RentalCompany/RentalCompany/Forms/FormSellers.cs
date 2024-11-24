using RentalCompany.Repositories;
using Unity;

namespace RentalCompany.Forms;

public partial class FormSellers : Form
{
    private readonly IUnityContainer _container;
    private readonly ISellerRepository _sellerRepository;

    public FormSellers(IUnityContainer container, ISellerRepository sellerRepository)
    {
        InitializeComponent();
        _container = container ?? throw new ArgumentNullException(nameof(container));
        _sellerRepository =
            sellerRepository ?? throw new ArgumentNullException(nameof(sellerRepository));
    }

    private void FormSellers_Load(object sender, EventArgs e)
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
            _container.Resolve<FormSeller>().ShowDialog();
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

    private void ButtonUpd_Click(object sender, EventArgs e)
    {
        if (!TryGetIdentifierFromSelectedRow(out var findId))
        {
            return;
        }

        try
        {
            var form = _container.Resolve<FormClient>();
            form.Id = findId;
            form.ShowDialog();
            LoadList();
        }
        catch (Exception ex)
        {
            MessageBox.Show(
                ex.Message,
                "Ошибка при изменении",
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
            _sellerRepository.DeleteSeller(findId);
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

    private void LoadList() => dataGridViewData.DataSource = _sellerRepository.ReadSellers();

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
}
