namespace RentalCompany.Forms
{
    partial class FormProductReturns
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
            buttonAdd = new Button();
            dataGridViewData = new DataGridView();
            ColumnClient = new DataGridViewTextBoxColumn();
            ColumnDate = new DataGridViewTextBoxColumn();
            ColumnFine = new DataGridViewTextBoxColumn();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewData).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add( buttonDel );
            panel1.Controls.Add( buttonAdd );
            panel1.Dock = DockStyle.Right;
            panel1.Location = new Point( 642, 0 );
            panel1.Name = "panel1";
            panel1.Size = new Size( 158, 450 );
            panel1.TabIndex = 0;
            // 
            // buttonDel
            // 
            buttonDel.BackgroundImage = Properties.Resources.del_icon;
            buttonDel.BackgroundImageLayout = ImageLayout.Zoom;
            buttonDel.Location = new Point( 39, 188 );
            buttonDel.Name = "buttonDel";
            buttonDel.Size = new Size( 88, 77 );
            buttonDel.TabIndex = 1;
            buttonDel.UseVisualStyleBackColor = true;
            buttonDel.Click += ButtonDel_Click;
            // 
            // buttonAdd
            // 
            buttonAdd.BackgroundImage = Properties.Resources.add_icon;
            buttonAdd.BackgroundImageLayout = ImageLayout.Zoom;
            buttonAdd.Location = new Point( 39, 95 );
            buttonAdd.Name = "buttonAdd";
            buttonAdd.Size = new Size( 88, 77 );
            buttonAdd.TabIndex = 0;
            buttonAdd.UseVisualStyleBackColor = true;
            buttonAdd.Click += ButtonAdd_Click;
            // 
            // dataGridViewData
            // 
            dataGridViewData.AllowUserToAddRows = false;
            dataGridViewData.AllowUserToDeleteRows = false;
            dataGridViewData.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewData.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewData.Columns.AddRange( new DataGridViewColumn[] { ColumnClient, ColumnDate, ColumnFine } );
            dataGridViewData.Dock = DockStyle.Fill;
            dataGridViewData.Location = new Point( 0, 0 );
            dataGridViewData.Name = "dataGridViewData";
            dataGridViewData.ReadOnly = true;
            dataGridViewData.RowHeadersVisible = false;
            dataGridViewData.RowHeadersWidth = 51;
            dataGridViewData.Size = new Size( 642, 450 );
            dataGridViewData.TabIndex = 1;
            // 
            // ColumnClient
            // 
            ColumnClient.HeaderText = "Клиент";
            ColumnClient.MinimumWidth = 6;
            ColumnClient.Name = "ColumnClient";
            ColumnClient.ReadOnly = true;
            // 
            // ColumnDate
            // 
            ColumnDate.HeaderText = "Дата";
            ColumnDate.MinimumWidth = 6;
            ColumnDate.Name = "ColumnDate";
            ColumnDate.ReadOnly = true;
            // 
            // ColumnFine
            // 
            ColumnFine.HeaderText = "Штраф";
            ColumnFine.MinimumWidth = 6;
            ColumnFine.Name = "ColumnFine";
            ColumnFine.ReadOnly = true;
            // 
            // FormProductReturns
            // 
            AutoScaleDimensions = new SizeF( 8F, 20F );
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size( 800, 450 );
            Controls.Add( dataGridViewData );
            Controls.Add( panel1 );
            Name = "FormProductReturns";
            Text = "Возвраты";
            panel1.ResumeLayout( false );
            ((System.ComponentModel.ISupportInitialize)dataGridViewData).EndInit();
            ResumeLayout( false );
        }

        #endregion

        private Panel panel1;
        private DataGridView dataGridViewData;
        private Button buttonAdd;
        private Button buttonDel;
        private DataGridViewTextBoxColumn ColumnClient;
        private DataGridViewTextBoxColumn ColumnDate;
        private DataGridViewTextBoxColumn ColumnFine;
    }
}