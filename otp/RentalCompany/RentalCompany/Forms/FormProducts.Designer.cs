namespace RentalCompany.Forms
{
    partial class FormProducts
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
            dataGridViewData = new DataGridView();
            panel1 = new Panel();
            buttonDelete = new Button();
            buttonUpdate = new Button();
            buttonCreate = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridViewData).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
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
            dataGridViewData.Size = new Size( 1217, 450 );
            dataGridViewData.TabIndex = 0;
            // 
            // panel1
            // 
            panel1.Controls.Add( buttonDelete );
            panel1.Controls.Add( buttonUpdate );
            panel1.Controls.Add( buttonCreate );
            panel1.Dock = DockStyle.Right;
            panel1.Location = new Point( 1056, 0 );
            panel1.Name = "panel1";
            panel1.Size = new Size( 161, 450 );
            panel1.TabIndex = 1;
            // 
            // buttonDelete
            // 
            buttonDelete.BackgroundImage = Properties.Resources.del_icon;
            buttonDelete.BackgroundImageLayout = ImageLayout.Zoom;
            buttonDelete.Location = new Point( 30, 279 );
            buttonDelete.Name = "buttonDelete";
            buttonDelete.Size = new Size( 119, 113 );
            buttonDelete.TabIndex = 3;
            buttonDelete.UseVisualStyleBackColor = true;
            buttonDelete.Click += ButtonDelete_Click;
            // 
            // buttonUpdate
            // 
            buttonUpdate.BackgroundImage = Properties.Resources.edit_icon;
            buttonUpdate.BackgroundImageLayout = ImageLayout.Zoom;
            buttonUpdate.Location = new Point( 30, 149 );
            buttonUpdate.Name = "buttonUpdate";
            buttonUpdate.Size = new Size( 119, 113 );
            buttonUpdate.TabIndex = 2;
            buttonUpdate.UseVisualStyleBackColor = true;
            buttonUpdate.Click += ButtonUpdate_Click;
            // 
            // buttonCreate
            // 
            buttonCreate.BackgroundImage = Properties.Resources.add_icon;
            buttonCreate.BackgroundImageLayout = ImageLayout.Zoom;
            buttonCreate.Location = new Point( 30, 24 );
            buttonCreate.Name = "buttonCreate";
            buttonCreate.Size = new Size( 119, 113 );
            buttonCreate.TabIndex = 0;
            buttonCreate.UseVisualStyleBackColor = true;
            buttonCreate.Click += ButtonCreate_Click;
            // 
            // FormProducts
            // 
            AutoScaleDimensions = new SizeF( 8F, 20F );
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size( 1217, 450 );
            Controls.Add( panel1 );
            Controls.Add( dataGridViewData );
            Name = "FormProducts";
            Text = "Товары";
            Load += FormProducts_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridViewData).EndInit();
            panel1.ResumeLayout( false );
            ResumeLayout( false );
        }

        #endregion

        private DataGridView dataGridViewData;
        private Panel panel1;
        private Button buttonDelete;
        private Button buttonUpdate;
        private Button buttonCreate;
    }
}