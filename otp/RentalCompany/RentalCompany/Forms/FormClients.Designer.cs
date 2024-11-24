namespace RentalCompany.Forms
{
    partial class FormClients
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
            buttonUpd = new Button();
            buttonAdd = new Button();
            dataGridViewData = new DataGridView();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewData).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add( buttonDel );
            panel1.Controls.Add( buttonUpd );
            panel1.Controls.Add( buttonAdd );
            panel1.Dock = DockStyle.Right;
            panel1.Location = new Point( 894, 0 );
            panel1.Name = "panel1";
            panel1.Size = new Size( 186, 450 );
            panel1.TabIndex = 0;
            // 
            // buttonDel
            // 
            buttonDel.BackgroundImage = Properties.Resources.del_icon;
            buttonDel.BackgroundImageLayout = ImageLayout.Zoom;
            buttonDel.Location = new Point( 41, 216 );
            buttonDel.Name = "buttonDel";
            buttonDel.Size = new Size( 113, 96 );
            buttonDel.TabIndex = 2;
            buttonDel.UseVisualStyleBackColor = true;
            buttonDel.Click += ButtonDel_Click;
            // 
            // buttonUpd
            // 
            buttonUpd.BackgroundImage = Properties.Resources.edit_icon;
            buttonUpd.BackgroundImageLayout = ImageLayout.Zoom;
            buttonUpd.Location = new Point( 41, 114 );
            buttonUpd.Name = "buttonUpd";
            buttonUpd.Size = new Size( 112, 96 );
            buttonUpd.TabIndex = 1;
            buttonUpd.UseVisualStyleBackColor = true;
            buttonUpd.Click += ButtonUpd_Click;
            // 
            // buttonAdd
            // 
            buttonAdd.BackgroundImage = Properties.Resources.add_icon;
            buttonAdd.BackgroundImageLayout = ImageLayout.Zoom;
            buttonAdd.Location = new Point( 40, 12 );
            buttonAdd.Name = "buttonAdd";
            buttonAdd.Size = new Size( 113, 96 );
            buttonAdd.TabIndex = 0;
            buttonAdd.UseVisualStyleBackColor = true;
            buttonAdd.Click += ButtonAdd_Click;
            // 
            // dataGridViewData
            // 
            dataGridViewData.AllowUserToAddRows = false;
            dataGridViewData.AllowUserToDeleteRows = false;
            dataGridViewData.AllowUserToResizeColumns = false;
            dataGridViewData.AllowUserToResizeRows = false;
            dataGridViewData.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewData.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewData.Dock = DockStyle.Fill;
            dataGridViewData.Location = new Point( 0, 0 );
            dataGridViewData.MultiSelect = false;
            dataGridViewData.Name = "dataGridViewData";
            dataGridViewData.ReadOnly = true;
            dataGridViewData.RowHeadersVisible = false;
            dataGridViewData.RowHeadersWidth = 51;
            dataGridViewData.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridViewData.Size = new Size( 894, 450 );
            dataGridViewData.TabIndex = 1;
            // 
            // FormClients
            // 
            AutoScaleDimensions = new SizeF( 8F, 20F );
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size( 1080, 450 );
            Controls.Add( dataGridViewData );
            Controls.Add( panel1 );
            Name = "FormClients";
            Text = "Клиенты";
            Load += FormClients_Load;
            panel1.ResumeLayout( false );
            ((System.ComponentModel.ISupportInitialize)dataGridViewData).EndInit();
            ResumeLayout( false );
        }

        #endregion

        private Panel panel1;
        private DataGridView dataGridViewData;
        private Button buttonUpd;
        private Button buttonAdd;
        private Button buttonDel;
    }
}