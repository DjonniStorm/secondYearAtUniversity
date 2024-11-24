﻿using RentalCompany.Repositories;
using Unity;

namespace RentalCompany.Forms;

public partial class FormProducts : Form
{
    private readonly IUnityContainer _container;

    private readonly IProductRepository _productRepository;

    public FormProducts(IUnityContainer container, IProductRepository productRepository)
    {
        InitializeComponent();
        _container = container ?? throw new ArgumentNullException(nameof(container));
        _productRepository =
            productRepository ?? throw new ArgumentNullException(nameof(productRepository));
    }

    private void ButtonCreate_Click(object sender, EventArgs e)
    {
        try
        {
            _container.Resolve<FormProduct>().ShowDialog();
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

    private void ButtonUpdate_Click(object sender, EventArgs e)
    {
        if (!TryGetIdentifierFromSelectedRow(out var findId))
        {
            return;
        }

        try
        {
            var form = _container.Resolve<FormProduct>();
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

    private void ButtonDelete_Click(object sender, EventArgs e)
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
            _productRepository.DeleteProduct(findId);
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

    private void FormProducts_Load(object sender, EventArgs e)
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

    private void LoadList() => dataGridViewData.DataSource = _productRepository.ReadProducts();

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
