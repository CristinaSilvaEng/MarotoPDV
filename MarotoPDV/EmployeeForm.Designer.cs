namespace MarotoPDV
{
    partial class EmployeeForm
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EmployeeForm));
            this.groupBox_employee = new System.Windows.Forms.GroupBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.maskedTextBox_telephone = new System.Windows.Forms.MaskedTextBox();
            this.comboBox_level = new System.Windows.Forms.ComboBox();
            this.textBox_password = new System.Windows.Forms.TextBox();
            this.textBox_name = new System.Windows.Forms.TextBox();
            this.label_telephone = new System.Windows.Forms.Label();
            this.label_address = new System.Windows.Forms.Label();
            this.label_level = new System.Windows.Forms.Label();
            this.label_password = new System.Windows.Forms.Label();
            this.label_name = new System.Windows.Forms.Label();
            this.label_id = new System.Windows.Forms.Label();
            this.button_create = new System.Windows.Forms.Button();
            this.button_update = new System.Windows.Forms.Button();
            this.button_delete = new System.Windows.Forms.Button();
            this.button_search = new System.Windows.Forms.Button();
            this.button_cancel = new System.Windows.Forms.Button();
            this.button_close = new System.Windows.Forms.Button();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.pictureBox_logoStore = new System.Windows.Forms.PictureBox();
            this.groupBox_employee.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_logoStore)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox_employee
            // 
            this.groupBox_employee.Controls.Add(this.textBox1);
            this.groupBox_employee.Controls.Add(this.maskedTextBox_telephone);
            this.groupBox_employee.Controls.Add(this.comboBox_level);
            this.groupBox_employee.Controls.Add(this.textBox_password);
            this.groupBox_employee.Controls.Add(this.textBox_name);
            this.groupBox_employee.Controls.Add(this.label_telephone);
            this.groupBox_employee.Controls.Add(this.label_address);
            this.groupBox_employee.Controls.Add(this.label_level);
            this.groupBox_employee.Controls.Add(this.label_password);
            this.groupBox_employee.Controls.Add(this.label_name);
            this.groupBox_employee.Controls.Add(this.pictureBox_logoStore);
            this.groupBox_employee.Controls.Add(this.label_id);
            this.groupBox_employee.Location = new System.Drawing.Point(12, 12);
            this.groupBox_employee.Name = "groupBox_employee";
            this.groupBox_employee.Size = new System.Drawing.Size(517, 221);
            this.groupBox_employee.TabIndex = 0;
            this.groupBox_employee.TabStop = false;
            this.groupBox_employee.Text = "Employee";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(9, 150);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(413, 60);
            this.textBox1.TabIndex = 11;
            // 
            // maskedTextBox_telephone
            // 
            this.maskedTextBox_telephone.Location = new System.Drawing.Point(243, 100);
            this.maskedTextBox_telephone.Name = "maskedTextBox_telephone";
            this.maskedTextBox_telephone.Size = new System.Drawing.Size(179, 20);
            this.maskedTextBox_telephone.TabIndex = 10;
            // 
            // comboBox_level
            // 
            this.comboBox_level.FormattingEnabled = true;
            this.comboBox_level.Location = new System.Drawing.Point(48, 100);
            this.comboBox_level.Name = "comboBox_level";
            this.comboBox_level.Size = new System.Drawing.Size(121, 21);
            this.comboBox_level.TabIndex = 9;
            // 
            // textBox_password
            // 
            this.textBox_password.Location = new System.Drawing.Point(68, 62);
            this.textBox_password.Name = "textBox_password";
            this.textBox_password.Size = new System.Drawing.Size(354, 20);
            this.textBox_password.TabIndex = 8;
            // 
            // textBox_name
            // 
            this.textBox_name.Location = new System.Drawing.Point(50, 27);
            this.textBox_name.Name = "textBox_name";
            this.textBox_name.Size = new System.Drawing.Size(372, 20);
            this.textBox_name.TabIndex = 7;
            // 
            // label_telephone
            // 
            this.label_telephone.AutoSize = true;
            this.label_telephone.Location = new System.Drawing.Point(176, 103);
            this.label_telephone.Name = "label_telephone";
            this.label_telephone.Size = new System.Drawing.Size(61, 13);
            this.label_telephone.TabIndex = 6;
            this.label_telephone.Text = "Telephone:";
            // 
            // label_address
            // 
            this.label_address.AutoSize = true;
            this.label_address.Location = new System.Drawing.Point(6, 134);
            this.label_address.Name = "label_address";
            this.label_address.Size = new System.Drawing.Size(48, 13);
            this.label_address.TabIndex = 5;
            this.label_address.Text = "Address:";
            // 
            // label_level
            // 
            this.label_level.AutoSize = true;
            this.label_level.Location = new System.Drawing.Point(6, 103);
            this.label_level.Name = "label_level";
            this.label_level.Size = new System.Drawing.Size(36, 13);
            this.label_level.TabIndex = 4;
            this.label_level.Text = "Level:";
            // 
            // label_password
            // 
            this.label_password.AutoSize = true;
            this.label_password.Location = new System.Drawing.Point(6, 65);
            this.label_password.Name = "label_password";
            this.label_password.Size = new System.Drawing.Size(56, 13);
            this.label_password.TabIndex = 3;
            this.label_password.Text = "Password:";
            // 
            // label_name
            // 
            this.label_name.AutoSize = true;
            this.label_name.Location = new System.Drawing.Point(6, 30);
            this.label_name.Name = "label_name";
            this.label_name.Size = new System.Drawing.Size(38, 13);
            this.label_name.TabIndex = 2;
            this.label_name.Text = "Name:";
            // 
            // label_id
            // 
            this.label_id.AutoSize = true;
            this.label_id.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_id.Location = new System.Drawing.Point(448, 70);
            this.label_id.Name = "label_id";
            this.label_id.Size = new System.Drawing.Size(54, 20);
            this.label_id.TabIndex = 0;
            this.label_id.Text = "#0001";
            // 
            // button_create
            // 
            this.button_create.Location = new System.Drawing.Point(12, 251);
            this.button_create.Name = "button_create";
            this.button_create.Size = new System.Drawing.Size(75, 23);
            this.button_create.TabIndex = 1;
            this.button_create.Text = "Create";
            this.button_create.UseVisualStyleBackColor = true;
            this.button_create.Click += new System.EventHandler(this.button_create_Click);
            // 
            // button_update
            // 
            this.button_update.Location = new System.Drawing.Point(174, 252);
            this.button_update.Name = "button_update";
            this.button_update.Size = new System.Drawing.Size(75, 23);
            this.button_update.TabIndex = 2;
            this.button_update.Text = "Update";
            this.button_update.UseVisualStyleBackColor = true;
            this.button_update.Click += new System.EventHandler(this.button_update_Click);
            // 
            // button_delete
            // 
            this.button_delete.Location = new System.Drawing.Point(255, 252);
            this.button_delete.Name = "button_delete";
            this.button_delete.Size = new System.Drawing.Size(75, 23);
            this.button_delete.TabIndex = 3;
            this.button_delete.Text = "Delete";
            this.button_delete.UseVisualStyleBackColor = true;
            this.button_delete.Click += new System.EventHandler(this.button_delete_Click);
            // 
            // button_search
            // 
            this.button_search.Location = new System.Drawing.Point(93, 252);
            this.button_search.Name = "button_search";
            this.button_search.Size = new System.Drawing.Size(75, 23);
            this.button_search.TabIndex = 4;
            this.button_search.Text = "Search";
            this.button_search.UseVisualStyleBackColor = true;
            // 
            // button_cancel
            // 
            this.button_cancel.Location = new System.Drawing.Point(373, 252);
            this.button_cancel.Name = "button_cancel";
            this.button_cancel.Size = new System.Drawing.Size(75, 23);
            this.button_cancel.TabIndex = 5;
            this.button_cancel.Text = "Cancel";
            this.button_cancel.UseVisualStyleBackColor = true;
            // 
            // button_close
            // 
            this.button_close.Location = new System.Drawing.Point(454, 252);
            this.button_close.Name = "button_close";
            this.button_close.Size = new System.Drawing.Size(75, 23);
            this.button_close.TabIndex = 6;
            this.button_close.Text = "Close";
            this.button_close.UseVisualStyleBackColor = true;
            // 
            // imageList1
            // 
            this.imageList1.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
            this.imageList1.ImageSize = new System.Drawing.Size(16, 16);
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // pictureBox_logoStore
            // 
            this.pictureBox_logoStore.Image = global::MarotoPDV.Properties.Resources.logo_store;
            this.pictureBox_logoStore.Location = new System.Drawing.Point(452, 17);
            this.pictureBox_logoStore.Name = "pictureBox_logoStore";
            this.pictureBox_logoStore.Size = new System.Drawing.Size(48, 50);
            this.pictureBox_logoStore.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox_logoStore.TabIndex = 1;
            this.pictureBox_logoStore.TabStop = false;
            // 
            // EmployeeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(541, 287);
            this.Controls.Add(this.button_close);
            this.Controls.Add(this.button_cancel);
            this.Controls.Add(this.button_search);
            this.Controls.Add(this.button_delete);
            this.Controls.Add(this.button_update);
            this.Controls.Add(this.button_create);
            this.Controls.Add(this.groupBox_employee);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "EmployeeForm";
            this.Text = "MarotoPDV";
            this.groupBox_employee.ResumeLayout(false);
            this.groupBox_employee.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_logoStore)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox_employee;
        private System.Windows.Forms.Button button_create;
        private System.Windows.Forms.Button button_update;
        private System.Windows.Forms.Button button_delete;
        private System.Windows.Forms.Label label_id;
        private System.Windows.Forms.Button button_search;
        private System.Windows.Forms.Button button_cancel;
        private System.Windows.Forms.Button button_close;
        private System.Windows.Forms.Label label_address;
        private System.Windows.Forms.Label label_level;
        private System.Windows.Forms.Label label_password;
        private System.Windows.Forms.Label label_name;
        private System.Windows.Forms.PictureBox pictureBox_logoStore;
        private System.Windows.Forms.Label label_telephone;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.MaskedTextBox maskedTextBox_telephone;
        private System.Windows.Forms.ComboBox comboBox_level;
        private System.Windows.Forms.TextBox textBox_password;
        private System.Windows.Forms.TextBox textBox_name;
        private System.Windows.Forms.ImageList imageList1;
    }
}