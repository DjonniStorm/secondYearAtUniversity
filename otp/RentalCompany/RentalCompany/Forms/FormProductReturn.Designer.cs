namespace RentalCompany.Forms
{
    partial class FormProductReturn
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose( bool disposing )
        {
            if ( disposing && (components != null) )
            {
                components.Dispose();
            }
            base.Dispose( disposing );
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            comboBoxClients = new ComboBox();
            labelClient = new Label();
            numericUpDownFine = new NumericUpDown();
            labelFine = new Label();
            dataGridViewData = new DataGridView();
            ColumnProduct = new DataGridViewComboBoxColumn();
            ColumnReturn = new DataGridViewCheckBoxColumn();
            buttonSave = new Button();
            buttonCancel = new Button();
            ((System.ComponentModel.ISupportInitialize)numericUpDownFine).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridViewData).BeginInit();
            SuspendLayout();
            // 
            // comboBoxClients
            // 
            comboBoxClients.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxClients.FormattingEnabled = true;
            comboBoxClients.Location = new Point( 175, 45 );
            comboBoxClients.Name = "comboBoxClients";
            comboBoxClients.Size = new Size( 151, 28 );
            comboBoxClients.TabIndex = 0;
            // 
            // labelClient
            // 
            labelClient.AutoSize = true;
            labelClient.Location = new Point( 49, 45 );
            labelClient.Name = "labelClient";
            labelClient.Size = new Size( 61, 20 );
            labelClient.TabIndex = 1;
            labelClient.Text = "Клиент:";
            // 
            // numericUpDownFine
            // 
            numericUpDownFine.DecimalPlaces = 2;
            numericUpDownFine.Enabled = false;
            numericUpDownFine.Location = new Point( 175, 101 );
            numericUpDownFine.Name = "numericUpDownFine";
            numericUpDownFine.Size = new Size( 150, 27 );
            numericUpDownFine.TabIndex = 2;
            // 
            // labelFine
            // 
            labelFine.AutoSize = true;
            labelFine.Location = new Point( 49, 108 );
            labelFine.Name = "labelFine";
            labelFine.Size = new Size( 59, 20 );
            labelFine.TabIndex = 3;
            labelFine.Text = "Штраф:";
            // 
            // dataGridViewData
            // 
            dataGridViewData.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewData.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewData.Columns.AddRange( new DataGridViewColumn[] { ColumnProduct, ColumnReturn } );
            dataGridViewData.Location = new Point( 37, 158 );
            dataGridViewData.Name = "dataGridViewData";
            dataGridViewData.RowHeadersVisible = false;
            dataGridViewData.RowHeadersWidth = 51;
            dataGridViewData.Size = new Size( 300, 228 );
            dataGridViewData.TabIndex = 4;
            // 
            // ColumnProduct
            // 
            ColumnProduct.HeaderText = "Товар";
            ColumnProduct.MinimumWidth = 6;
            ColumnProduct.Name = "ColumnProduct";
            ColumnProduct.Resizable = DataGridViewTriState.True;
            ColumnProduct.SortMode = DataGridViewColumnSortMode.Automatic;
            // 
            // ColumnReturn
            // 
            ColumnReturn.HeaderText = "Возврат";
            ColumnReturn.MinimumWidth = 6;
            ColumnReturn.Name = "ColumnReturn";
            // 
            // buttonSave
            // 
            buttonSave.Location = new Point( 12, 396 );
            buttonSave.Name = "buttonSave";
            buttonSave.Size = new Size( 123, 42 );
            buttonSave.TabIndex = 5;
            buttonSave.Text = "Сохранить";
            buttonSave.UseVisualStyleBackColor = true;
            buttonSave.Click += ButtonSave_Click;
            // 
            // buttonCancel
            // 
            buttonCancel.Location = new Point( 227, 396 );
            buttonCancel.Name = "buttonCancel";
            buttonCancel.Size = new Size( 123, 42 );
            buttonCancel.TabIndex = 6;
            buttonCancel.Text = "Отмена";
            buttonCancel.UseVisualStyleBackColor = true;
            buttonCancel.Click += ButtonCancel_Click;
            // 
            // FormProductReturn
            // 
            AutoScaleDimensions = new SizeF( 8F, 20F );
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size( 362, 450 );
            Controls.Add( buttonCancel );
            Controls.Add( buttonSave );
            Controls.Add( dataGridViewData );
            Controls.Add( labelFine );
            Controls.Add( numericUpDownFine );
            Controls.Add( labelClient );
            Controls.Add( comboBoxClients );
            Name = "FormProductReturn";
            Text = "Возврат товара";
            ((System.ComponentModel.ISupportInitialize)numericUpDownFine).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridViewData).EndInit();
            ResumeLayout( false );
            PerformLayout();
        }

        #endregion

        private ComboBox comboBoxClients;
        private Label labelClient;
        private NumericUpDown numericUpDownFine;
        private Label labelFine;
        private DataGridView dataGridViewData;
        private DataGridViewComboBoxColumn ColumnProduct;
        private DataGridViewCheckBoxColumn ColumnReturn;
        private Button buttonSave;
        private Button buttonCancel;
    }
}