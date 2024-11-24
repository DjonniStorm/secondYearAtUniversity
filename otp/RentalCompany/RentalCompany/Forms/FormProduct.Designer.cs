namespace RentalCompany.Forms
{
    partial class FormProduct
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
            labelProductName = new Label();
            textBoxName = new TextBox();
            richTextBoxDescription = new RichTextBox();
            labelProductDescription = new Label();
            numericUpDownPrice = new NumericUpDown();
            labelProductPrice = new Label();
            numericUpDownTotal = new NumericUpDown();
            labelProductTotal = new Label();
            labelProductAgeLimit = new Label();
            numericUpDownAgeLimit = new NumericUpDown();
            labelProductGenre = new Label();
            comboBoxProductType = new ComboBox();
            labelProductType = new Label();
            buttonSave = new Button();
            buttonCancel = new Button();
            textBoxProductGenre = new TextBox();
            ((System.ComponentModel.ISupportInitialize)numericUpDownPrice).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDownTotal).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDownAgeLimit).BeginInit();
            SuspendLayout();
            // 
            // labelProductName
            // 
            labelProductName.AutoSize = true;
            labelProductName.Location = new Point( 12, 19 );
            labelProductName.Name = "labelProductName";
            labelProductName.Size = new Size( 80, 20 );
            labelProductName.TabIndex = 0;
            labelProductName.Text = "Название:";
            // 
            // textBoxName
            // 
            textBoxName.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            textBoxName.Location = new Point( 198, 16 );
            textBoxName.Name = "textBoxName";
            textBoxName.Size = new Size( 251, 27 );
            textBoxName.TabIndex = 1;
            // 
            // richTextBoxDescription
            // 
            richTextBoxDescription.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            richTextBoxDescription.Location = new Point( 198, 60 );
            richTextBoxDescription.Name = "richTextBoxDescription";
            richTextBoxDescription.Size = new Size( 251, 117 );
            richTextBoxDescription.TabIndex = 2;
            richTextBoxDescription.Text = "";
            // 
            // labelProductDescription
            // 
            labelProductDescription.AutoSize = true;
            labelProductDescription.Location = new Point( 12, 63 );
            labelProductDescription.Name = "labelProductDescription";
            labelProductDescription.Size = new Size( 82, 20 );
            labelProductDescription.TabIndex = 3;
            labelProductDescription.Text = "Описание:";
            // 
            // numericUpDownPrice
            // 
            numericUpDownPrice.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            numericUpDownPrice.DecimalPlaces = 2;
            numericUpDownPrice.Location = new Point( 198, 196 );
            numericUpDownPrice.Maximum = new decimal( new int[] { 500, 0, 0, 0 } );
            numericUpDownPrice.Name = "numericUpDownPrice";
            numericUpDownPrice.Size = new Size( 251, 27 );
            numericUpDownPrice.TabIndex = 4;
            // 
            // labelProductPrice
            // 
            labelProductPrice.AutoSize = true;
            labelProductPrice.Location = new Point( 10, 203 );
            labelProductPrice.Name = "labelProductPrice";
            labelProductPrice.Size = new Size( 48, 20 );
            labelProductPrice.TabIndex = 5;
            labelProductPrice.Text = "Цена:";
            // 
            // numericUpDownTotal
            // 
            numericUpDownTotal.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            numericUpDownTotal.Location = new Point( 198, 240 );
            numericUpDownTotal.Maximum = new decimal( new int[] { 500, 0, 0, 0 } );
            numericUpDownTotal.Name = "numericUpDownTotal";
            numericUpDownTotal.Size = new Size( 251, 27 );
            numericUpDownTotal.TabIndex = 6;
            // 
            // labelProductTotal
            // 
            labelProductTotal.AutoSize = true;
            labelProductTotal.Location = new Point( 10, 242 );
            labelProductTotal.Name = "labelProductTotal";
            labelProductTotal.Size = new Size( 51, 20 );
            labelProductTotal.TabIndex = 7;
            labelProductTotal.Text = "Всего:";
            // 
            // labelProductAgeLimit
            // 
            labelProductAgeLimit.AutoSize = true;
            labelProductAgeLimit.Location = new Point( 10, 295 );
            labelProductAgeLimit.Name = "labelProductAgeLimit";
            labelProductAgeLimit.Size = new Size( 189, 20 );
            labelProductAgeLimit.TabIndex = 8;
            labelProductAgeLimit.Text = "Возрастное ограничение:";
            // 
            // numericUpDownAgeLimit
            // 
            numericUpDownAgeLimit.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            numericUpDownAgeLimit.Location = new Point( 198, 293 );
            numericUpDownAgeLimit.Maximum = new decimal( new int[] { 21, 0, 0, 0 } );
            numericUpDownAgeLimit.Name = "numericUpDownAgeLimit";
            numericUpDownAgeLimit.Size = new Size( 251, 27 );
            numericUpDownAgeLimit.TabIndex = 9;
            // 
            // labelProductGenre
            // 
            labelProductGenre.AutoSize = true;
            labelProductGenre.Location = new Point( 12, 342 );
            labelProductGenre.Name = "labelProductGenre";
            labelProductGenre.Size = new Size( 51, 20 );
            labelProductGenre.TabIndex = 11;
            labelProductGenre.Text = "Жанр:";
            // 
            // comboBoxProductType
            // 
            comboBoxProductType.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            comboBoxProductType.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxProductType.FormattingEnabled = true;
            comboBoxProductType.Location = new Point( 198, 384 );
            comboBoxProductType.Name = "comboBoxProductType";
            comboBoxProductType.Size = new Size( 251, 28 );
            comboBoxProductType.TabIndex = 12;
            // 
            // labelProductType
            // 
            labelProductType.AutoSize = true;
            labelProductType.Location = new Point( 12, 387 );
            labelProductType.Name = "labelProductType";
            labelProductType.Size = new Size( 38, 20 );
            labelProductType.TabIndex = 13;
            labelProductType.Text = "Тип:";
            // 
            // buttonSave
            // 
            buttonSave.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            buttonSave.Location = new Point( 58, 431 );
            buttonSave.Name = "buttonSave";
            buttonSave.Size = new Size( 120, 39 );
            buttonSave.TabIndex = 14;
            buttonSave.Text = "Сохранить";
            buttonSave.UseVisualStyleBackColor = true;
            buttonSave.Click += ButtonSave_Click;
            // 
            // buttonCancel
            // 
            buttonCancel.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            buttonCancel.Location = new Point( 288, 431 );
            buttonCancel.Name = "buttonCancel";
            buttonCancel.Size = new Size( 120, 39 );
            buttonCancel.TabIndex = 15;
            buttonCancel.Text = "Отмена";
            buttonCancel.UseVisualStyleBackColor = true;
            buttonCancel.Click += ButtonCancel_Click;
            // 
            // textBoxProductGenre
            // 
            textBoxProductGenre.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            textBoxProductGenre.Location = new Point( 198, 339 );
            textBoxProductGenre.Name = "textBoxProductGenre";
            textBoxProductGenre.Size = new Size( 251, 27 );
            textBoxProductGenre.TabIndex = 16;
            // 
            // FormProduct
            // 
            AutoScaleDimensions = new SizeF( 8F, 20F );
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size( 482, 482 );
            Controls.Add( textBoxProductGenre );
            Controls.Add( buttonCancel );
            Controls.Add( buttonSave );
            Controls.Add( labelProductType );
            Controls.Add( comboBoxProductType );
            Controls.Add( labelProductGenre );
            Controls.Add( numericUpDownAgeLimit );
            Controls.Add( labelProductAgeLimit );
            Controls.Add( labelProductTotal );
            Controls.Add( numericUpDownTotal );
            Controls.Add( labelProductPrice );
            Controls.Add( numericUpDownPrice );
            Controls.Add( labelProductDescription );
            Controls.Add( richTextBoxDescription );
            Controls.Add( textBoxName );
            Controls.Add( labelProductName );
            Name = "FormProduct";
            Text = "Товар";
            ((System.ComponentModel.ISupportInitialize)numericUpDownPrice).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDownTotal).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDownAgeLimit).EndInit();
            ResumeLayout( false );
            PerformLayout();
        }

        #endregion

        private Label labelProductName;
        private TextBox textBoxName;
        private RichTextBox richTextBoxDescription;
        private Label labelProductDescription;
        private NumericUpDown numericUpDownPrice;
        private Label labelProductPrice;
        private NumericUpDown numericUpDownTotal;
        private Label labelProductTotal;
        private Label labelProductAgeLimit;
        private NumericUpDown numericUpDownAgeLimit;
        private Label labelProductGenre;
        private ComboBox comboBoxProductType;
        private Label labelProductType;
        private Button buttonSave;
        private Button buttonCancel;
        private TextBox textBoxProductGenre;
    }
}