namespace RentalCompany
{
    partial class FormRentalCompany
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
            menuStrip = new MenuStrip();
            DirectoriesToolStripMenuItem = new ToolStripMenuItem();
            ClientsToolStripMenuItem = new ToolStripMenuItem();
            SellersToolStripMenuItem = new ToolStripMenuItem();
            ProductsToolStripMenuItem = new ToolStripMenuItem();
            OperationsToolStripMenuItem = new ToolStripMenuItem();
            RentalToolStripMenuItem = new ToolStripMenuItem();
            ProductReturnToolStripMenuItem = new ToolStripMenuItem();
            отчётыToolStripMenuItem = new ToolStripMenuItem();
            menuStrip.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip
            // 
            menuStrip.ImageScalingSize = new Size( 20, 20 );
            menuStrip.Items.AddRange( new ToolStripItem[] { DirectoriesToolStripMenuItem, OperationsToolStripMenuItem, отчётыToolStripMenuItem } );
            menuStrip.Location = new Point( 0, 0 );
            menuStrip.Name = "menuStrip";
            menuStrip.Size = new Size( 803, 28 );
            menuStrip.TabIndex = 0;
            menuStrip.Text = "menuStrip";
            // 
            // DirectoriesToolStripMenuItem
            // 
            DirectoriesToolStripMenuItem.DropDownItems.AddRange( new ToolStripItem[] { ClientsToolStripMenuItem, SellersToolStripMenuItem, ProductsToolStripMenuItem } );
            DirectoriesToolStripMenuItem.Name = "DirectoriesToolStripMenuItem";
            DirectoriesToolStripMenuItem.Size = new Size( 117, 24 );
            DirectoriesToolStripMenuItem.Text = "Справочники";
            // 
            // ClientsToolStripMenuItem
            // 
            ClientsToolStripMenuItem.Name = "ClientsToolStripMenuItem";
            ClientsToolStripMenuItem.Size = new Size( 266, 26 );
            ClientsToolStripMenuItem.Text = "Клиенты";
            ClientsToolStripMenuItem.Click += ClientsToolStripMenuItem_Click;
            // 
            // SellersToolStripMenuItem
            // 
            SellersToolStripMenuItem.Name = "SellersToolStripMenuItem";
            SellersToolStripMenuItem.Size = new Size( 266, 26 );
            SellersToolStripMenuItem.Text = "Продавцы-консультанты";
            SellersToolStripMenuItem.Click += SellersToolStripMenuItem_Click;
            // 
            // ProductsToolStripMenuItem
            // 
            ProductsToolStripMenuItem.Name = "ProductsToolStripMenuItem";
            ProductsToolStripMenuItem.Size = new Size( 266, 26 );
            ProductsToolStripMenuItem.Text = "Товары";
            ProductsToolStripMenuItem.Click += ProductsToolStripMenuItem_Click;
            // 
            // OperationsToolStripMenuItem
            // 
            OperationsToolStripMenuItem.DropDownItems.AddRange( new ToolStripItem[] { RentalToolStripMenuItem, ProductReturnToolStripMenuItem } );
            OperationsToolStripMenuItem.Name = "OperationsToolStripMenuItem";
            OperationsToolStripMenuItem.Size = new Size( 95, 24 );
            OperationsToolStripMenuItem.Text = "Операции";
            // 
            // RentalToolStripMenuItem
            // 
            RentalToolStripMenuItem.Name = "RentalToolStripMenuItem";
            RentalToolStripMenuItem.Size = new Size( 224, 26 );
            RentalToolStripMenuItem.Text = "Аренда";
            RentalToolStripMenuItem.Click += RentalToolStripMenuItem_Click;
            // 
            // ProductReturnToolStripMenuItem
            // 
            ProductReturnToolStripMenuItem.Name = "ProductReturnToolStripMenuItem";
            ProductReturnToolStripMenuItem.Size = new Size( 224, 26 );
            ProductReturnToolStripMenuItem.Text = "Возврат";
            ProductReturnToolStripMenuItem.Click += ProductReturnToolStripMenuItem_Click;
            // 
            // отчётыToolStripMenuItem
            // 
            отчётыToolStripMenuItem.Name = "отчётыToolStripMenuItem";
            отчётыToolStripMenuItem.Size = new Size( 73, 24 );
            отчётыToolStripMenuItem.Text = "Отчёты";
            // 
            // FormRentalCompany
            // 
            AutoScaleDimensions = new SizeF( 8F, 20F );
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.MainBackground;
            BackgroundImageLayout = ImageLayout.Zoom;
            ClientSize = new Size( 803, 427 );
            Controls.Add( menuStrip );
            DoubleBuffered = true;
            MainMenuStrip = menuStrip;
            Name = "FormRentalCompany";
            Text = "Фирма по прокату";
            menuStrip.ResumeLayout( false );
            menuStrip.PerformLayout();
            ResumeLayout( false );
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip;
        private ToolStripMenuItem DirectoriesToolStripMenuItem;
        private ToolStripMenuItem OperationsToolStripMenuItem;
        private ToolStripMenuItem отчётыToolStripMenuItem;
        private ToolStripMenuItem ClientsToolStripMenuItem;
        private ToolStripMenuItem SellersToolStripMenuItem;
        private ToolStripMenuItem ProductsToolStripMenuItem;
        private ToolStripMenuItem RentalToolStripMenuItem;
        private ToolStripMenuItem ProductReturnToolStripMenuItem;
    }
}