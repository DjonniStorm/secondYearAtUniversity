using RentalCompany.Forms;
using Unity;

namespace RentalCompany;

public partial class FormRentalCompany : Form
{
    private readonly IUnityContainer _container;

    public FormRentalCompany(IUnityContainer container)
    {
        InitializeComponent();
        _container = container ?? throw new ArgumentNullException(nameof(container));
    }

    private void ClientsToolStripMenuItem_Click(object sender, EventArgs e)
    {
        try
        {
            _container.Resolve<FormClients>().ShowDialog();
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

    private void ProductsToolStripMenuItem_Click(object sender, EventArgs e)
    {
        try
        {
            _container.Resolve<FormProducts>().ShowDialog();
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

    private void SellersToolStripMenuItem_Click(object sender, EventArgs e)
    {
        try
        {
            _container.Resolve<FormSellers>().ShowDialog();
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

    private void RentalToolStripMenuItem_Click(object sender, EventArgs e)
    {
        try
        {
            _container.Resolve<FormReceipts>().ShowDialog();
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

    private void ProductReturnToolStripMenuItem_Click(object sender, EventArgs e)
    {
        try
        {
            _container.Resolve<FormProductReturns>().ShowDialog();
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
}
