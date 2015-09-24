namespace MarotoPDV
{
    partial class SaleForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SaleForm));
            this.groupBox_sale = new System.Windows.Forms.GroupBox();
            this.listView_saleItems = new System.Windows.Forms.ListView();
            this.button_generate = new System.Windows.Forms.Button();
            this.button_logout = new System.Windows.Forms.Button();
            this.label_idOperator = new System.Windows.Forms.Label();
            this.label_operator = new System.Windows.Forms.Label();
            this.groupBox_total = new System.Windows.Forms.GroupBox();
            this.label_currency = new System.Windows.Forms.Label();
            this.label_value = new System.Windows.Forms.Label();
            this.groupBox_search = new System.Windows.Forms.GroupBox();
            this.label_id = new System.Windows.Forms.Label();
            this.textBox_id = new System.Windows.Forms.TextBox();
            this.button_searchID = new System.Windows.Forms.Button();
            this.button_cancel = new System.Windows.Forms.Button();
            this.listView_products = new System.Windows.Forms.ListView();
            this.button_clean = new System.Windows.Forms.Button();
            this.button_cart = new System.Windows.Forms.Button();
            this.numericUpDown_quantity = new System.Windows.Forms.NumericUpDown();
            this.label_quantity = new System.Windows.Forms.Label();
            this.groupBox_sale.SuspendLayout();
            this.groupBox_total.SuspendLayout();
            this.groupBox_search.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_quantity)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox_sale
            // 
            this.groupBox_sale.Controls.Add(this.groupBox_search);
            this.groupBox_sale.Controls.Add(this.groupBox_total);
            this.groupBox_sale.Controls.Add(this.listView_saleItems);
            this.groupBox_sale.Location = new System.Drawing.Point(12, 12);
            this.groupBox_sale.Name = "groupBox_sale";
            this.groupBox_sale.Size = new System.Drawing.Size(613, 412);
            this.groupBox_sale.TabIndex = 0;
            this.groupBox_sale.TabStop = false;
            this.groupBox_sale.Text = "Sale";
            // 
            // listView_saleItems
            // 
            this.listView_saleItems.Location = new System.Drawing.Point(6, 19);
            this.listView_saleItems.Name = "listView_saleItems";
            this.listView_saleItems.Size = new System.Drawing.Size(317, 387);
            this.listView_saleItems.TabIndex = 0;
            this.listView_saleItems.UseCompatibleStateImageBehavior = false;
            // 
            // button_generate
            // 
            this.button_generate.Location = new System.Drawing.Point(18, 440);
            this.button_generate.Name = "button_generate";
            this.button_generate.Size = new System.Drawing.Size(112, 23);
            this.button_generate.TabIndex = 1;
            this.button_generate.Text = "Generate Sale";
            this.button_generate.UseVisualStyleBackColor = true;
            // 
            // button_logout
            // 
            this.button_logout.Location = new System.Drawing.Point(550, 440);
            this.button_logout.Name = "button_logout";
            this.button_logout.Size = new System.Drawing.Size(75, 23);
            this.button_logout.TabIndex = 3;
            this.button_logout.Text = "Logout";
            this.button_logout.UseVisualStyleBackColor = true;
            this.button_logout.Click += new System.EventHandler(this.button_logout_Click);
            // 
            // label_idOperator
            // 
            this.label_idOperator.AutoSize = true;
            this.label_idOperator.Location = new System.Drawing.Point(509, 445);
            this.label_idOperator.Name = "label_idOperator";
            this.label_idOperator.Size = new System.Drawing.Size(37, 13);
            this.label_idOperator.TabIndex = 4;
            this.label_idOperator.Text = "00001";
            // 
            // label_operator
            // 
            this.label_operator.AutoSize = true;
            this.label_operator.Location = new System.Drawing.Point(471, 445);
            this.label_operator.Name = "label_operator";
            this.label_operator.Size = new System.Drawing.Size(32, 13);
            this.label_operator.TabIndex = 5;
            this.label_operator.Text = "OP #";
            // 
            // groupBox_total
            // 
            this.groupBox_total.Controls.Add(this.label_value);
            this.groupBox_total.Controls.Add(this.label_currency);
            this.groupBox_total.Location = new System.Drawing.Point(332, 341);
            this.groupBox_total.Name = "groupBox_total";
            this.groupBox_total.Size = new System.Drawing.Size(275, 65);
            this.groupBox_total.TabIndex = 1;
            this.groupBox_total.TabStop = false;
            this.groupBox_total.Text = "Total";
            // 
            // label_currency
            // 
            this.label_currency.AutoSize = true;
            this.label_currency.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_currency.Location = new System.Drawing.Point(160, 25);
            this.label_currency.Name = "label_currency";
            this.label_currency.Size = new System.Drawing.Size(24, 26);
            this.label_currency.TabIndex = 0;
            this.label_currency.Text = "$";
            // 
            // label_value
            // 
            this.label_value.AutoSize = true;
            this.label_value.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_value.Location = new System.Drawing.Point(191, 25);
            this.label_value.Name = "label_value";
            this.label_value.Size = new System.Drawing.Size(78, 26);
            this.label_value.TabIndex = 1;
            this.label_value.Text = "297,00";
            // 
            // groupBox_search
            // 
            this.groupBox_search.Controls.Add(this.label_quantity);
            this.groupBox_search.Controls.Add(this.numericUpDown_quantity);
            this.groupBox_search.Controls.Add(this.button_cart);
            this.groupBox_search.Controls.Add(this.button_clean);
            this.groupBox_search.Controls.Add(this.listView_products);
            this.groupBox_search.Controls.Add(this.button_searchID);
            this.groupBox_search.Controls.Add(this.textBox_id);
            this.groupBox_search.Controls.Add(this.label_id);
            this.groupBox_search.Location = new System.Drawing.Point(332, 19);
            this.groupBox_search.Name = "groupBox_search";
            this.groupBox_search.Size = new System.Drawing.Size(275, 316);
            this.groupBox_search.TabIndex = 2;
            this.groupBox_search.TabStop = false;
            this.groupBox_search.Text = "Search";
            // 
            // label_id
            // 
            this.label_id.AutoSize = true;
            this.label_id.Location = new System.Drawing.Point(6, 28);
            this.label_id.Name = "label_id";
            this.label_id.Size = new System.Drawing.Size(21, 13);
            this.label_id.TabIndex = 0;
            this.label_id.Text = "ID:";
            // 
            // textBox_id
            // 
            this.textBox_id.Location = new System.Drawing.Point(58, 25);
            this.textBox_id.Name = "textBox_id";
            this.textBox_id.Size = new System.Drawing.Size(130, 20);
            this.textBox_id.TabIndex = 1;
            // 
            // button_searchID
            // 
            this.button_searchID.Location = new System.Drawing.Point(194, 22);
            this.button_searchID.Name = "button_searchID";
            this.button_searchID.Size = new System.Drawing.Size(75, 23);
            this.button_searchID.TabIndex = 6;
            this.button_searchID.Text = "Search";
            this.button_searchID.UseVisualStyleBackColor = true;
            this.button_searchID.Click += new System.EventHandler(this.button_searchID_Click);
            // 
            // button_cancel
            // 
            this.button_cancel.Location = new System.Drawing.Point(149, 440);
            this.button_cancel.Name = "button_cancel";
            this.button_cancel.Size = new System.Drawing.Size(112, 23);
            this.button_cancel.TabIndex = 6;
            this.button_cancel.Text = "Cancel Sale";
            this.button_cancel.UseVisualStyleBackColor = true;
            // 
            // listView_products
            // 
            this.listView_products.FullRowSelect = true;
            this.listView_products.Location = new System.Drawing.Point(6, 51);
            this.listView_products.Name = "listView_products";
            this.listView_products.Size = new System.Drawing.Size(263, 224);
            this.listView_products.TabIndex = 16;
            this.listView_products.UseCompatibleStateImageBehavior = false;
            // 
            // button_clean
            // 
            this.button_clean.Location = new System.Drawing.Point(194, 281);
            this.button_clean.Name = "button_clean";
            this.button_clean.Size = new System.Drawing.Size(75, 23);
            this.button_clean.TabIndex = 17;
            this.button_clean.Text = "Clean";
            this.button_clean.UseVisualStyleBackColor = true;
            // 
            // button_cart
            // 
            this.button_cart.Location = new System.Drawing.Point(113, 281);
            this.button_cart.Name = "button_cart";
            this.button_cart.Size = new System.Drawing.Size(75, 23);
            this.button_cart.TabIndex = 18;
            this.button_cart.Text = "Add to Cart";
            this.button_cart.UseVisualStyleBackColor = true;
            // 
            // numericUpDown_quantity
            // 
            this.numericUpDown_quantity.Location = new System.Drawing.Point(58, 284);
            this.numericUpDown_quantity.Name = "numericUpDown_quantity";
            this.numericUpDown_quantity.Size = new System.Drawing.Size(49, 20);
            this.numericUpDown_quantity.TabIndex = 19;
            // 
            // label_quantity
            // 
            this.label_quantity.AutoSize = true;
            this.label_quantity.Location = new System.Drawing.Point(3, 286);
            this.label_quantity.Name = "label_quantity";
            this.label_quantity.Size = new System.Drawing.Size(49, 13);
            this.label_quantity.TabIndex = 20;
            this.label_quantity.Text = "Quantity:";
            // 
            // SaleForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(637, 475);
            this.Controls.Add(this.button_cancel);
            this.Controls.Add(this.label_operator);
            this.Controls.Add(this.label_idOperator);
            this.Controls.Add(this.button_logout);
            this.Controls.Add(this.button_generate);
            this.Controls.Add(this.groupBox_sale);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "SaleForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MarotoPVD";
            this.groupBox_sale.ResumeLayout(false);
            this.groupBox_total.ResumeLayout(false);
            this.groupBox_total.PerformLayout();
            this.groupBox_search.ResumeLayout(false);
            this.groupBox_search.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_quantity)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox_sale;
        private System.Windows.Forms.GroupBox groupBox_search;
        private System.Windows.Forms.Button button_searchID;
        private System.Windows.Forms.TextBox textBox_id;
        private System.Windows.Forms.Label label_id;
        private System.Windows.Forms.GroupBox groupBox_total;
        private System.Windows.Forms.Label label_value;
        private System.Windows.Forms.Label label_currency;
        private System.Windows.Forms.ListView listView_saleItems;
        private System.Windows.Forms.Button button_generate;
        private System.Windows.Forms.Button button_logout;
        private System.Windows.Forms.Label label_idOperator;
        private System.Windows.Forms.Label label_operator;
        private System.Windows.Forms.Button button_cancel;
        private System.Windows.Forms.ListView listView_products;
        private System.Windows.Forms.Label label_quantity;
        private System.Windows.Forms.NumericUpDown numericUpDown_quantity;
        private System.Windows.Forms.Button button_cart;
        private System.Windows.Forms.Button button_clean;
    }
}