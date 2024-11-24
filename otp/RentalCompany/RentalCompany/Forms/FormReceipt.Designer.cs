namespace RentalCompany.Forms
{
    partial class FormReceipt
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
            buttonSave = new Button();
            buttonCancel = new Button();
            dataGridViewData = new DataGridView();
            columnProduct = new DataGridViewComboBoxColumn();
            ColumnRentalTime = new DataGridViewTextBoxColumn();
            labelClient = new Label();
            comboBoxClients = new ComboBox();
            labelSeller = new Label();
            comboBoxSellers = new ComboBox();
            numericUpDownTotal = new NumericUpDown();
            labelTotal = new Label();
            numericUpDownDiscount = new NumericUpDown();
            labelDiscount = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGridViewData).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDownTotal).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDownDiscount).BeginInit();
            SuspendLayout();
            // 
            // buttonSave
            // 
            buttonSave.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            buttonSave.Location = new Point( 28, 469 );
            buttonSave.Name = "buttonSave";
            buttonSave.Size = new Size( 107, 37 );
            buttonSave.TabIndex = 0;
            buttonSave.Text = "Сохранить";
            buttonSave.UseVisualStyleBackColor = true;
            buttonSave.Click += ButtonSave_Click;
            // 
            // buttonCancel
            // 
            buttonCancel.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            buttonCancel.Location = new Point( 229, 469 );
            buttonCancel.Name = "buttonCancel";
            buttonCancel.Size = new Size( 107, 37 );
            buttonCancel.TabIndex = 1;
            buttonCancel.Text = "Отмена";
            buttonCancel.UseVisualStyleBackColor = true;
            buttonCancel.Click += ButtonCancel_Click;
            // 
            // dataGridViewData
            // 
            dataGridViewData.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dataGridViewData.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewData.ColumnHeadersHeight = 29;
            dataGridViewData.Columns.AddRange( new DataGridViewColumn[] { columnProduct, ColumnRentalTime } );
            dataGridViewData.Location = new Point( 28, 190 );
            dataGridViewData.Name = "dataGridViewData";
            dataGridViewData.RowHeadersVisible = false;
            dataGridViewData.RowHeadersWidth = 51;
            dataGridViewData.Size = new Size( 302, 261 );
            dataGridViewData.TabIndex = 2;
            // 
            // columnProduct
            // 
            columnProduct.HeaderText = "Товар";
            columnProduct.MinimumWidth = 6;
            columnProduct.Name = "columnProduct";
            // 
            // ColumnRentalTime
            // 
            ColumnRentalTime.HeaderText = "Время проката";
            ColumnRentalTime.MinimumWidth = 6;
            ColumnRentalTime.Name = "ColumnRentalTime";
            // 
            // labelClient
            // 
            labelClient.AutoSize = true;
            labelClient.Location = new Point( 66, 25 );
            labelClient.Name = "labelClient";
            labelClient.Size = new Size( 61, 20 );
            labelClient.TabIndex = 5;
            labelClient.Text = "Клиент:";
            // 
            // comboBoxClients
            // 
            comboBoxClients.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxClients.FormattingEnabled = true;
            comboBoxClients.Location = new Point( 157, 22 );
            comboBoxClients.Name = "comboBoxClients";
            comboBoxClients.Size = new Size( 151, 28 );
            comboBoxClients.TabIndex = 6;
            // 
            // labelSeller
            // 
            labelSeller.AutoSize = true;
            labelSeller.Location = new Point( 66, 66 );
            labelSeller.Name = "labelSeller";
            labelSeller.Size = new Size( 82, 20 );
            labelSeller.TabIndex = 7;
            labelSeller.Text = "Продавец:";
            // 
            // comboBoxSellers
            // 
            comboBoxSellers.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxSellers.FormattingEnabled = true;
            comboBoxSellers.Location = new Point( 157, 68 );
            comboBoxSellers.Name = "comboBoxSellers";
            comboBoxSellers.Size = new Size( 151, 28 );
            comboBoxSellers.TabIndex = 8;
            // 
            // numericUpDownTotal
            // 
            numericUpDownTotal.DecimalPlaces = 2;
            numericUpDownTotal.Enabled = false;
            numericUpDownTotal.Location = new Point( 157, 157 );
            numericUpDownTotal.Name = "numericUpDownTotal";
            numericUpDownTotal.Size = new Size( 150, 27 );
            numericUpDownTotal.TabIndex = 9;
            // 
            // labelTotal
            // 
            labelTotal.AutoSize = true;
            labelTotal.Location = new Point( 66, 157 );
            labelTotal.Name = "labelTotal";
            labelTotal.Size = new Size( 44, 20 );
            labelTotal.TabIndex = 10;
            labelTotal.Text = "Итог:";
            // 
            // numericUpDownDiscount
            // 
            numericUpDownDiscount.DecimalPlaces = 2;
            numericUpDownDiscount.Enabled = false;
            numericUpDownDiscount.Location = new Point( 158, 112 );
            numericUpDownDiscount.Name = "numericUpDownDiscount";
            numericUpDownDiscount.Size = new Size( 150, 27 );
            numericUpDownDiscount.TabIndex = 11;
            // 
            // labelDiscount
            // 
            labelDiscount.AutoSize = true;
            labelDiscount.Location = new Point( 66, 114 );
            labelDiscount.Name = "labelDiscount";
            labelDiscount.Size = new Size( 60, 20 );
            labelDiscount.TabIndex = 12;
            labelDiscount.Text = "Скидка:";
            // 
            // FormReceipt
            // 
            AutoScaleDimensions = new SizeF( 8F, 20F );
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size( 360, 518 );
            Controls.Add( labelDiscount );
            Controls.Add( numericUpDownDiscount );
            Controls.Add( labelTotal );
            Controls.Add( numericUpDownTotal );
            Controls.Add( comboBoxSellers );
            Controls.Add( labelSeller );
            Controls.Add( comboBoxClients );
            Controls.Add( labelClient );
            Controls.Add( dataGridViewData );
            Controls.Add( buttonCancel );
            Controls.Add( buttonSave );
            Name = "FormReceipt";
            Text = "Чек";
            ((System.ComponentModel.ISupportInitialize)dataGridViewData).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDownTotal).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDownDiscount).EndInit();
            ResumeLayout( false );
            PerformLayout();
        }

        #endregion

        private Button buttonSave;
        private Button buttonCancel;
        private DataGridView dataGridViewData;
        private DataGridViewComboBoxColumn columnProduct;
        private DataGridViewTextBoxColumn ColumnRentalTime;
        private Label labelClient;
        private ComboBox comboBoxClients;
        private Label labelSeller;
        private ComboBox comboBoxSellers;
        private NumericUpDown numericUpDownTotal;
        private Label labelTotal;
        private NumericUpDown numericUpDownDiscount;
        private Label labelDiscount;
    }
}