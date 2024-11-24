namespace RentalCompany.Forms
{
    partial class FormSeller
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
            textBoxSellerName = new TextBox();
            labelSellerName = new Label();
            buttonSave = new Button();
            numericUpDownSellerWorkExp = new NumericUpDown();
            labelSellerSurname = new Label();
            textBoxSellerSurname = new TextBox();
            labelSellerWorkExp = new Label();
            labelSellerPhone = new Label();
            labelSellerEmail = new Label();
            textBoxSellerPhone = new TextBox();
            textBoxSellerEmail = new TextBox();
            buttonCancel = new Button();
            checkedListBoxType = new CheckedListBox();
            labelType = new Label();
            ((System.ComponentModel.ISupportInitialize)numericUpDownSellerWorkExp).BeginInit();
            SuspendLayout();
            // 
            // textBoxSellerName
            // 
            textBoxSellerName.Location = new Point( 142, 19 );
            textBoxSellerName.Name = "textBoxSellerName";
            textBoxSellerName.Size = new Size( 168, 27 );
            textBoxSellerName.TabIndex = 0;
            // 
            // labelSellerName
            // 
            labelSellerName.AutoSize = true;
            labelSellerName.Location = new Point( 36, 26 );
            labelSellerName.Name = "labelSellerName";
            labelSellerName.Size = new Size( 42, 20 );
            labelSellerName.TabIndex = 1;
            labelSellerName.Text = "Имя:";
            // 
            // buttonSave
            // 
            buttonSave.Location = new Point( 56, 426 );
            buttonSave.Name = "buttonSave";
            buttonSave.Size = new Size( 115, 35 );
            buttonSave.TabIndex = 2;
            buttonSave.Text = "Сохранить";
            buttonSave.UseVisualStyleBackColor = true;
            buttonSave.Click += ButtonSave_Click;
            // 
            // numericUpDownSellerWorkExp
            // 
            numericUpDownSellerWorkExp.Location = new Point( 142, 134 );
            numericUpDownSellerWorkExp.Name = "numericUpDownSellerWorkExp";
            numericUpDownSellerWorkExp.Size = new Size( 168, 27 );
            numericUpDownSellerWorkExp.TabIndex = 3;
            // 
            // labelSellerSurname
            // 
            labelSellerSurname.AutoSize = true;
            labelSellerSurname.Location = new Point( 36, 84 );
            labelSellerSurname.Name = "labelSellerSurname";
            labelSellerSurname.Size = new Size( 76, 20 );
            labelSellerSurname.TabIndex = 4;
            labelSellerSurname.Text = "Фамилия:";
            // 
            // textBoxSellerSurname
            // 
            textBoxSellerSurname.Location = new Point( 142, 81 );
            textBoxSellerSurname.Name = "textBoxSellerSurname";
            textBoxSellerSurname.Size = new Size( 168, 27 );
            textBoxSellerSurname.TabIndex = 5;
            // 
            // labelSellerWorkExp
            // 
            labelSellerWorkExp.AutoSize = true;
            labelSellerWorkExp.Location = new Point( 36, 136 );
            labelSellerWorkExp.Name = "labelSellerWorkExp";
            labelSellerWorkExp.Size = new Size( 49, 20 );
            labelSellerWorkExp.TabIndex = 6;
            labelSellerWorkExp.Text = "Опыт:";
            // 
            // labelSellerPhone
            // 
            labelSellerPhone.AutoSize = true;
            labelSellerPhone.Location = new Point( 36, 190 );
            labelSellerPhone.Name = "labelSellerPhone";
            labelSellerPhone.Size = new Size( 72, 20 );
            labelSellerPhone.TabIndex = 7;
            labelSellerPhone.Text = "Телефон:";
            // 
            // labelSellerEmail
            // 
            labelSellerEmail.AutoSize = true;
            labelSellerEmail.Location = new Point( 36, 230 );
            labelSellerEmail.Name = "labelSellerEmail";
            labelSellerEmail.Size = new Size( 49, 20 );
            labelSellerEmail.TabIndex = 8;
            labelSellerEmail.Text = "Email:";
            // 
            // textBoxSellerPhone
            // 
            textBoxSellerPhone.Location = new Point( 142, 183 );
            textBoxSellerPhone.Name = "textBoxSellerPhone";
            textBoxSellerPhone.Size = new Size( 168, 27 );
            textBoxSellerPhone.TabIndex = 9;
            // 
            // textBoxSellerEmail
            // 
            textBoxSellerEmail.Location = new Point( 142, 230 );
            textBoxSellerEmail.Name = "textBoxSellerEmail";
            textBoxSellerEmail.Size = new Size( 168, 27 );
            textBoxSellerEmail.TabIndex = 10;
            // 
            // buttonCancel
            // 
            buttonCancel.Location = new Point( 206, 426 );
            buttonCancel.Name = "buttonCancel";
            buttonCancel.Size = new Size( 115, 35 );
            buttonCancel.TabIndex = 11;
            buttonCancel.Text = "Отмена";
            buttonCancel.UseVisualStyleBackColor = true;
            buttonCancel.Click += ButtonCancel_Click;
            // 
            // checkedListBoxType
            // 
            checkedListBoxType.FormattingEnabled = true;
            checkedListBoxType.Location = new Point( 142, 279 );
            checkedListBoxType.Name = "checkedListBoxType";
            checkedListBoxType.Size = new Size( 168, 136 );
            checkedListBoxType.TabIndex = 12;
            // 
            // labelType
            // 
            labelType.AutoSize = true;
            labelType.Location = new Point( 36, 279 );
            labelType.Name = "labelType";
            labelType.Size = new Size( 89, 20 );
            labelType.TabIndex = 13;
            labelType.Text = "Должность:";
            // 
            // FormSeller
            // 
            AutoScaleDimensions = new SizeF( 8F, 20F );
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size( 375, 470 );
            Controls.Add( labelType );
            Controls.Add( checkedListBoxType );
            Controls.Add( buttonCancel );
            Controls.Add( textBoxSellerEmail );
            Controls.Add( textBoxSellerPhone );
            Controls.Add( labelSellerEmail );
            Controls.Add( labelSellerPhone );
            Controls.Add( labelSellerWorkExp );
            Controls.Add( textBoxSellerSurname );
            Controls.Add( labelSellerSurname );
            Controls.Add( numericUpDownSellerWorkExp );
            Controls.Add( buttonSave );
            Controls.Add( labelSellerName );
            Controls.Add( textBoxSellerName );
            Name = "FormSeller";
            Text = "Продавец";
            ((System.ComponentModel.ISupportInitialize)numericUpDownSellerWorkExp).EndInit();
            ResumeLayout( false );
            PerformLayout();
        }

        #endregion

        private TextBox textBoxSellerName;
        private Label labelSellerName;
        private Button buttonSave;
        private NumericUpDown numericUpDownSellerWorkExp;
        private Label labelSellerSurname;
        private TextBox textBoxSellerSurname;
        private Label labelSellerWorkExp;
        private Label labelSellerPhone;
        private Label labelSellerEmail;
        private TextBox textBoxSellerPhone;
        private TextBox textBoxSellerEmail;
        private Button buttonCancel;
        private CheckedListBox checkedListBoxType;
        private Label labelType;
    }
}