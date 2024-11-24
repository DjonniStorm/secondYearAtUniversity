namespace RentalCompany.Forms
{
    partial class FormReceipts
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
            panel1 = new Panel();
            buttonDel = new Button();
            buttonCreate = new Button();
            dataGridViewData = new DataGridView();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewData).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add( buttonDel );
            panel1.Controls.Add( buttonCreate );
            panel1.Dock = DockStyle.Right;
            panel1.Location = new Point( 654, 0 );
            panel1.Name = "panel1";
            panel1.Size = new Size( 146, 450 );
            panel1.TabIndex = 0;
            // 
            // buttonDel
            // 
            buttonDel.BackgroundImage = Properties.Resources.del_icon;
            buttonDel.BackgroundImageLayout = ImageLayout.Zoom;
            buttonDel.Location = new Point( 29, 162 );
            buttonDel.Name = "buttonDel";
            buttonDel.Size = new Size( 91, 76 );
            buttonDel.TabIndex = 2;
            buttonDel.UseVisualStyleBackColor = true;
            buttonDel.Click += ButtonDel_Click;
            // 
            // buttonCreate
            // 
            buttonCreate.BackgroundImage = Properties.Resources.add_icon;
            buttonCreate.BackgroundImageLayout = ImageLayout.Zoom;
            buttonCreate.Location = new Point( 29, 60 );
            buttonCreate.Name = "buttonCreate";
            buttonCreate.Size = new Size( 91, 76 );
            buttonCreate.TabIndex = 0;
            buttonCreate.UseVisualStyleBackColor = true;
            buttonCreate.Click += ButtonAdd_Click;
            // 
            // dataGridViewData
            // 
            dataGridViewData.AllowUserToAddRows = false;
            dataGridViewData.AllowUserToDeleteRows = false;
            dataGridViewData.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewData.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewData.Dock = DockStyle.Fill;
            dataGridViewData.Location = new Point( 0, 0 );
            dataGridViewData.Name = "dataGridViewData";
            dataGridViewData.ReadOnly = true;
            dataGridViewData.RowHeadersVisible = false;
            dataGridViewData.RowHeadersWidth = 51;
            dataGridViewData.Size = new Size( 654, 450 );
            dataGridViewData.TabIndex = 1;
            // 
            // FormReceipts
            // 
            AutoScaleDimensions = new SizeF( 8F, 20F );
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size( 800, 450 );
            Controls.Add( dataGridViewData );
            Controls.Add( panel1 );
            Name = "FormReceipts";
            Text = "Чеки";
            Load += FormReceipts_Load;
            panel1.ResumeLayout( false );
            ((System.ComponentModel.ISupportInitialize)dataGridViewData).EndInit();
            ResumeLayout( false );
        }

        #endregion

        private Panel panel1;
        private DataGridView dataGridViewData;
        private Button buttonCreate;
        private Button buttonDel;
    }
}