namespace RentalCompany.Forms
{
    partial class FormClient
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
            textBoxClientName = new TextBox();
            textBoxClientSurname = new TextBox();
            labelName = new Label();
            labelSurname = new Label();
            labelPhone = new Label();
            textBoxClientPhone = new TextBox();
            numericUpDownLoayltyPoints = new NumericUpDown();
            labelLoyaltyPoints = new Label();
            labelDateOfBirth = new Label();
            dateTimePickerDateOfBirth = new DateTimePicker();
            buttonSave = new Button();
            buttonCancel = new Button();
            ((System.ComponentModel.ISupportInitialize)numericUpDownLoayltyPoints).BeginInit();
            SuspendLayout();
            // 
            // textBoxClientName
            // 
            textBoxClientName.Location = new Point( 159, 30 );
            textBoxClientName.Name = "textBoxClientName";
            textBoxClientName.Size = new Size( 180, 27 );
            textBoxClientName.TabIndex = 0;
            // 
            // textBoxClientSurname
            // 
            textBoxClientSurname.Location = new Point( 159, 76 );
            textBoxClientSurname.Name = "textBoxClientSurname";
            textBoxClientSurname.Size = new Size( 180, 27 );
            textBoxClientSurname.TabIndex = 1;
            // 
            // labelName
            // 
            labelName.AutoSize = true;
            labelName.Location = new Point( 12, 33 );
            labelName.Name = "labelName";
            labelName.Size = new Size( 42, 20 );
            labelName.TabIndex = 2;
            labelName.Text = "Имя:";
            // 
            // labelSurname
            // 
            labelSurname.AutoSize = true;
            labelSurname.Location = new Point( 12, 83 );
            labelSurname.Name = "labelSurname";
            labelSurname.Size = new Size( 76, 20 );
            labelSurname.TabIndex = 3;
            labelSurname.Text = "Фамилия:";
            // 
            // labelPhone
            // 
            labelPhone.AutoSize = true;
            labelPhone.Location = new Point( 12, 136 );
            labelPhone.Name = "labelPhone";
            labelPhone.Size = new Size( 72, 20 );
            labelPhone.TabIndex = 4;
            labelPhone.Text = "Телефон:";
            // 
            // textBoxClientPhone
            // 
            textBoxClientPhone.Location = new Point( 159, 133 );
            textBoxClientPhone.Name = "textBoxClientPhone";
            textBoxClientPhone.Size = new Size( 180, 27 );
            textBoxClientPhone.TabIndex = 6;
            // 
            // numericUpDownLoayltyPoints
            // 
            numericUpDownLoayltyPoints.Location = new Point( 159, 183 );
            numericUpDownLoayltyPoints.Name = "numericUpDownLoayltyPoints";
            numericUpDownLoayltyPoints.Size = new Size( 180, 27 );
            numericUpDownLoayltyPoints.TabIndex = 8;
            // 
            // labelLoyaltyPoints
            // 
            labelLoyaltyPoints.AutoSize = true;
            labelLoyaltyPoints.Location = new Point( 12, 185 );
            labelLoyaltyPoints.Name = "labelLoyaltyPoints";
            labelLoyaltyPoints.Size = new Size( 129, 20 );
            labelLoyaltyPoints.TabIndex = 9;
            labelLoyaltyPoints.Text = "Бонусные баллы:";
            // 
            // labelDateOfBirth
            // 
            labelDateOfBirth.AutoSize = true;
            labelDateOfBirth.Location = new Point( 12, 230 );
            labelDateOfBirth.Name = "labelDateOfBirth";
            labelDateOfBirth.Size = new Size( 119, 20 );
            labelDateOfBirth.TabIndex = 10;
            labelDateOfBirth.Text = "Дата рождения:";
            // 
            // dateTimePickerDateOfBirth
            // 
            dateTimePickerDateOfBirth.Location = new Point( 159, 230 );
            dateTimePickerDateOfBirth.Name = "dateTimePickerDateOfBirth";
            dateTimePickerDateOfBirth.Size = new Size( 180, 27 );
            dateTimePickerDateOfBirth.TabIndex = 11;
            // 
            // buttonSave
            // 
            buttonSave.Location = new Point( 53, 282 );
            buttonSave.Name = "buttonSave";
            buttonSave.Size = new Size( 108, 44 );
            buttonSave.TabIndex = 12;
            buttonSave.Text = "Сохранить";
            buttonSave.UseVisualStyleBackColor = true;
            buttonSave.Click += ButtonSave_Click;
            // 
            // buttonCancel
            // 
            buttonCancel.Location = new Point( 231, 282 );
            buttonCancel.Name = "buttonCancel";
            buttonCancel.Size = new Size( 108, 44 );
            buttonCancel.TabIndex = 13;
            buttonCancel.Text = "Отмена";
            buttonCancel.UseVisualStyleBackColor = true;
            buttonCancel.Click += ButtonCancel_Click;
            // 
            // FormClient
            // 
            AutoScaleDimensions = new SizeF( 8F, 20F );
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size( 386, 338 );
            Controls.Add( buttonCancel );
            Controls.Add( buttonSave );
            Controls.Add( dateTimePickerDateOfBirth );
            Controls.Add( labelDateOfBirth );
            Controls.Add( labelLoyaltyPoints );
            Controls.Add( numericUpDownLoayltyPoints );
            Controls.Add( textBoxClientPhone );
            Controls.Add( labelPhone );
            Controls.Add( labelSurname );
            Controls.Add( labelName );
            Controls.Add( textBoxClientSurname );
            Controls.Add( textBoxClientName );
            Name = "FormClient";
            Text = "Клиент";
            ((System.ComponentModel.ISupportInitialize)numericUpDownLoayltyPoints).EndInit();
            ResumeLayout( false );
            PerformLayout();
        }

        #endregion

        private TextBox textBoxClientName;
        private TextBox textBoxClientSurname;
        private Label labelName;
        private Label labelSurname;
        private Label labelPhone;
        private TextBox textBoxClientPhone;
        private NumericUpDown numericUpDownLoayltyPoints;
        private Label labelLoyaltyPoints;
        private Label labelDateOfBirth;
        private DateTimePicker dateTimePickerDateOfBirth;
        private Button buttonSave;
        private Button buttonCancel;
    }
}