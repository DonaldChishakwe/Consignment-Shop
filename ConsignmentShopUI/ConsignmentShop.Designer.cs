namespace ConsignmentShopUI
{
    partial class ConsignmentShop
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.headerText = new System.Windows.Forms.Label();
            this.itemsListbox = new System.Windows.Forms.ListBox();
            this.ItemsListboxLabel = new System.Windows.Forms.Label();
            this.AddToCart = new System.Windows.Forms.Button();
            this.ShoppingCartListboxLabel = new System.Windows.Forms.Label();
            this.ShoppingCartListbox = new System.Windows.Forms.ListBox();
            this.MakePurchase = new System.Windows.Forms.Button();
            this.vendorListboxLabel = new System.Windows.Forms.Label();
            this.vendorListbox = new System.Windows.Forms.ListBox();
            this.storePayoutLabel = new System.Windows.Forms.Label();
            this.storeProfitValue = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // headerText
            // 
            this.headerText.AutoSize = true;
            this.headerText.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.headerText.Location = new System.Drawing.Point(186, 0);
            this.headerText.Name = "headerText";
            this.headerText.Size = new System.Drawing.Size(405, 37);
            this.headerText.TabIndex = 0;
            this.headerText.Text = "Consignment Shop Demo";
            this.headerText.Click += new System.EventHandler(this.label1_Click);
            // 
            // itemsListbox
            // 
            this.itemsListbox.FormattingEnabled = true;
            this.itemsListbox.ItemHeight = 20;
            this.itemsListbox.Location = new System.Drawing.Point(49, 71);
            this.itemsListbox.Name = "itemsListbox";
            this.itemsListbox.Size = new System.Drawing.Size(308, 144);
            this.itemsListbox.TabIndex = 1;
            this.itemsListbox.SelectedIndexChanged += new System.EventHandler(this.ltemsListbox_SelectedIndexChanged);
            // 
            // ItemsListboxLabel
            // 
            this.ItemsListboxLabel.AutoSize = true;
            this.ItemsListboxLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ItemsListboxLabel.Location = new System.Drawing.Point(45, 48);
            this.ItemsListboxLabel.Name = "ItemsListboxLabel";
            this.ItemsListboxLabel.Size = new System.Drawing.Size(103, 20);
            this.ItemsListboxLabel.TabIndex = 2;
            this.ItemsListboxLabel.Text = "Store Items";
            this.ItemsListboxLabel.Click += new System.EventHandler(this.label1_Click_1);
            // 
            // AddToCart
            // 
            this.AddToCart.Location = new System.Drawing.Point(368, 138);
            this.AddToCart.Name = "AddToCart";
            this.AddToCart.Size = new System.Drawing.Size(127, 27);
            this.AddToCart.TabIndex = 3;
            this.AddToCart.Text = "Add To Cart >>";
            this.AddToCart.UseVisualStyleBackColor = true;
            this.AddToCart.Click += new System.EventHandler(this.AddToCart_Click);
            // 
            // ShoppingCartListboxLabel
            // 
            this.ShoppingCartListboxLabel.AutoSize = true;
            this.ShoppingCartListboxLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ShoppingCartListboxLabel.Location = new System.Drawing.Point(503, 48);
            this.ShoppingCartListboxLabel.Name = "ShoppingCartListboxLabel";
            this.ShoppingCartListboxLabel.Size = new System.Drawing.Size(124, 20);
            this.ShoppingCartListboxLabel.TabIndex = 5;
            this.ShoppingCartListboxLabel.Text = "Shopping Cart";
            // 
            // ShoppingCartListbox
            // 
            this.ShoppingCartListbox.FormattingEnabled = true;
            this.ShoppingCartListbox.ItemHeight = 20;
            this.ShoppingCartListbox.Location = new System.Drawing.Point(507, 71);
            this.ShoppingCartListbox.Name = "ShoppingCartListbox";
            this.ShoppingCartListbox.Size = new System.Drawing.Size(308, 144);
            this.ShoppingCartListbox.TabIndex = 4;
            // 
            // MakePurchase
            // 
            this.MakePurchase.Location = new System.Drawing.Point(599, 231);
            this.MakePurchase.Name = "MakePurchase";
            this.MakePurchase.Size = new System.Drawing.Size(127, 27);
            this.MakePurchase.TabIndex = 6;
            this.MakePurchase.Text = "Purchase";
            this.MakePurchase.UseVisualStyleBackColor = true;
            this.MakePurchase.Click += new System.EventHandler(this.MakePurchase_Click);
            // 
            // vendorListboxLabel
            // 
            this.vendorListboxLabel.AutoSize = true;
            this.vendorListboxLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.vendorListboxLabel.Location = new System.Drawing.Point(45, 264);
            this.vendorListboxLabel.Name = "vendorListboxLabel";
            this.vendorListboxLabel.Size = new System.Drawing.Size(76, 20);
            this.vendorListboxLabel.TabIndex = 8;
            this.vendorListboxLabel.Text = "Vendors";
            // 
            // vendorListbox
            // 
            this.vendorListbox.FormattingEnabled = true;
            this.vendorListbox.ItemHeight = 20;
            this.vendorListbox.Location = new System.Drawing.Point(49, 287);
            this.vendorListbox.Name = "vendorListbox";
            this.vendorListbox.Size = new System.Drawing.Size(308, 144);
            this.vendorListbox.TabIndex = 7;
            // 
            // storePayoutLabel
            // 
            this.storePayoutLabel.AutoSize = true;
            this.storePayoutLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.storePayoutLabel.Location = new System.Drawing.Point(567, 287);
            this.storePayoutLabel.Name = "storePayoutLabel";
            this.storePayoutLabel.Size = new System.Drawing.Size(116, 20);
            this.storePayoutLabel.TabIndex = 9;
            this.storePayoutLabel.Text = "Store Profit : ";
            // 
            // storeProfitValue
            // 
            this.storeProfitValue.AutoSize = true;
            this.storeProfitValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.storeProfitValue.Location = new System.Drawing.Point(700, 287);
            this.storeProfitValue.Name = "storeProfitValue";
            this.storeProfitValue.Size = new System.Drawing.Size(54, 20);
            this.storeProfitValue.TabIndex = 10;
            this.storeProfitValue.Text = "$0.00";
            // 
            // ConsignmentShop
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(862, 437);
            this.Controls.Add(this.storeProfitValue);
            this.Controls.Add(this.storePayoutLabel);
            this.Controls.Add(this.vendorListboxLabel);
            this.Controls.Add(this.vendorListbox);
            this.Controls.Add(this.MakePurchase);
            this.Controls.Add(this.ShoppingCartListboxLabel);
            this.Controls.Add(this.ShoppingCartListbox);
            this.Controls.Add(this.AddToCart);
            this.Controls.Add(this.ItemsListboxLabel);
            this.Controls.Add(this.itemsListbox);
            this.Controls.Add(this.headerText);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "ConsignmentShop";
            this.Text = "Consignment Shop Demo";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label headerText;
        private System.Windows.Forms.ListBox itemsListbox;
        private System.Windows.Forms.Label ItemsListboxLabel;
        private System.Windows.Forms.Button AddToCart;
        private System.Windows.Forms.Label ShoppingCartListboxLabel;
        private System.Windows.Forms.ListBox ShoppingCartListbox;
        private System.Windows.Forms.Button MakePurchase;
        private System.Windows.Forms.Label vendorListboxLabel;
        private System.Windows.Forms.ListBox vendorListbox;
        private System.Windows.Forms.Label storePayoutLabel;
        private System.Windows.Forms.Label storeProfitValue;
    }
}

