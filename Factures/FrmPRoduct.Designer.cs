
namespace Factures
{
    partial class FrmPRoduct
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmPRoduct));
            this.btn_save_pro = new System.Windows.Forms.Button();
            this.listView_product = new System.Windows.Forms.ListView();
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.label_list = new System.Windows.Forms.Label();
            this.btn_delete_pro = new System.Windows.Forms.Button();
            this.btn_edit_pro = new System.Windows.Forms.Button();
            this.btn_add_pro = new System.Windows.Forms.Button();
            this.btn_print = new System.Windows.Forms.Button();
            this.txt_price = new System.Windows.Forms.TextBox();
            this.label_price = new System.Windows.Forms.Label();
            this.txt_quantity = new System.Windows.Forms.TextBox();
            this.txt_name_pro = new System.Windows.Forms.TextBox();
            this.txt_reference = new System.Windows.Forms.TextBox();
            this.label_Quantity = new System.Windows.Forms.Label();
            this.label_reference_pro = new System.Windows.Forms.Label();
            this.label_name_pro = new System.Windows.Forms.Label();
            this.btn_refresh = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btn_save_pro
            // 
            this.btn_save_pro.BackColor = System.Drawing.Color.White;
            this.btn_save_pro.Font = new System.Drawing.Font("Bernard MT Condensed", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_save_pro.Location = new System.Drawing.Point(674, 252);
            this.btn_save_pro.Name = "btn_save_pro";
            this.btn_save_pro.Size = new System.Drawing.Size(50, 23);
            this.btn_save_pro.TabIndex = 90;
            this.btn_save_pro.Text = "Save";
            this.btn_save_pro.UseVisualStyleBackColor = false;
            this.btn_save_pro.Click += new System.EventHandler(this.btn_save_pro_Click);
            // 
            // listView_product
            // 
            this.listView_product.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader3,
            this.columnHeader4,
            this.columnHeader5,
            this.columnHeader6});
            this.listView_product.GridLines = true;
            this.listView_product.HideSelection = false;
            this.listView_product.Location = new System.Drawing.Point(330, 98);
            this.listView_product.Name = "listView_product";
            this.listView_product.Size = new System.Drawing.Size(394, 115);
            this.listView_product.TabIndex = 89;
            this.listView_product.UseCompatibleStateImageBehavior = false;
            this.listView_product.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Name";
            this.columnHeader3.Width = 90;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Reference";
            this.columnHeader4.Width = 90;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "Quantity";
            this.columnHeader5.Width = 90;
            // 
            // columnHeader6
            // 
            this.columnHeader6.Text = "Price";
            this.columnHeader6.Width = 113;
            // 
            // label_list
            // 
            this.label_list.AutoSize = true;
            this.label_list.Location = new System.Drawing.Point(327, 72);
            this.label_list.Name = "label_list";
            this.label_list.Size = new System.Drawing.Size(68, 13);
            this.label_list.TabIndex = 88;
            this.label_list.Text = "Products List";
            // 
            // btn_delete_pro
            // 
            this.btn_delete_pro.BackColor = System.Drawing.Color.White;
            this.btn_delete_pro.Font = new System.Drawing.Font("Bernard MT Condensed", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_delete_pro.Location = new System.Drawing.Point(562, 252);
            this.btn_delete_pro.Name = "btn_delete_pro";
            this.btn_delete_pro.Size = new System.Drawing.Size(106, 23);
            this.btn_delete_pro.TabIndex = 87;
            this.btn_delete_pro.Text = "Delete Product";
            this.btn_delete_pro.UseVisualStyleBackColor = false;
            this.btn_delete_pro.Click += new System.EventHandler(this.btn_delete_pro_Click);
            // 
            // btn_edit_pro
            // 
            this.btn_edit_pro.BackColor = System.Drawing.Color.White;
            this.btn_edit_pro.Font = new System.Drawing.Font("Bernard MT Condensed", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_edit_pro.Location = new System.Drawing.Point(435, 252);
            this.btn_edit_pro.Name = "btn_edit_pro";
            this.btn_edit_pro.Size = new System.Drawing.Size(112, 23);
            this.btn_edit_pro.TabIndex = 86;
            this.btn_edit_pro.Text = "Edit Product";
            this.btn_edit_pro.UseVisualStyleBackColor = false;
            this.btn_edit_pro.Click += new System.EventHandler(this.btn_edit_pro_Click);
            // 
            // btn_add_pro
            // 
            this.btn_add_pro.BackColor = System.Drawing.Color.White;
            this.btn_add_pro.Font = new System.Drawing.Font("Bernard MT Condensed", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_add_pro.Location = new System.Drawing.Point(330, 250);
            this.btn_add_pro.Name = "btn_add_pro";
            this.btn_add_pro.Size = new System.Drawing.Size(99, 23);
            this.btn_add_pro.TabIndex = 85;
            this.btn_add_pro.Text = "Add Product";
            this.btn_add_pro.UseVisualStyleBackColor = false;
            this.btn_add_pro.Click += new System.EventHandler(this.btn_add_pro_Click);
            // 
            // btn_print
            // 
            this.btn_print.BackColor = System.Drawing.Color.White;
            this.btn_print.Font = new System.Drawing.Font("Bernard MT Condensed", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_print.Location = new System.Drawing.Point(706, 321);
            this.btn_print.Name = "btn_print";
            this.btn_print.Size = new System.Drawing.Size(75, 23);
            this.btn_print.TabIndex = 91;
            this.btn_print.Text = "Print";
            this.btn_print.UseVisualStyleBackColor = false;
            this.btn_print.Click += new System.EventHandler(this.btn_print_Click);
            // 
            // txt_price
            // 
            this.txt_price.Location = new System.Drawing.Point(12, 252);
            this.txt_price.Multiline = true;
            this.txt_price.Name = "txt_price";
            this.txt_price.Size = new System.Drawing.Size(236, 23);
            this.txt_price.TabIndex = 99;
            // 
            // label_price
            // 
            this.label_price.AutoSize = true;
            this.label_price.Font = new System.Drawing.Font("Bernard MT Condensed", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_price.Location = new System.Drawing.Point(9, 221);
            this.label_price.Name = "label_price";
            this.label_price.Size = new System.Drawing.Size(34, 16);
            this.label_price.TabIndex = 98;
            this.label_price.Text = "Price";
            // 
            // txt_quantity
            // 
            this.txt_quantity.Location = new System.Drawing.Point(12, 190);
            this.txt_quantity.Multiline = true;
            this.txt_quantity.Name = "txt_quantity";
            this.txt_quantity.Size = new System.Drawing.Size(236, 23);
            this.txt_quantity.TabIndex = 97;
            // 
            // txt_name_pro
            // 
            this.txt_name_pro.Location = new System.Drawing.Point(12, 58);
            this.txt_name_pro.Multiline = true;
            this.txt_name_pro.Name = "txt_name_pro";
            this.txt_name_pro.Size = new System.Drawing.Size(236, 28);
            this.txt_name_pro.TabIndex = 96;
            // 
            // txt_reference
            // 
            this.txt_reference.Location = new System.Drawing.Point(12, 133);
            this.txt_reference.Multiline = true;
            this.txt_reference.Name = "txt_reference";
            this.txt_reference.Size = new System.Drawing.Size(236, 26);
            this.txt_reference.TabIndex = 95;
            // 
            // label_Quantity
            // 
            this.label_Quantity.AutoSize = true;
            this.label_Quantity.Font = new System.Drawing.Font("Bernard MT Condensed", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_Quantity.Location = new System.Drawing.Point(9, 171);
            this.label_Quantity.Name = "label_Quantity";
            this.label_Quantity.Size = new System.Drawing.Size(49, 16);
            this.label_Quantity.TabIndex = 94;
            this.label_Quantity.Text = "Quantity";
            // 
            // label_reference_pro
            // 
            this.label_reference_pro.AutoSize = true;
            this.label_reference_pro.Font = new System.Drawing.Font("Bernard MT Condensed", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_reference_pro.Location = new System.Drawing.Point(9, 100);
            this.label_reference_pro.Name = "label_reference_pro";
            this.label_reference_pro.Size = new System.Drawing.Size(100, 16);
            this.label_reference_pro.TabIndex = 93;
            this.label_reference_pro.Text = "Reference Product";
            // 
            // label_name_pro
            // 
            this.label_name_pro.AutoSize = true;
            this.label_name_pro.Font = new System.Drawing.Font("Bernard MT Condensed", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_name_pro.Location = new System.Drawing.Point(9, 34);
            this.label_name_pro.Name = "label_name_pro";
            this.label_name_pro.Size = new System.Drawing.Size(77, 16);
            this.label_name_pro.TabIndex = 92;
            this.label_name_pro.Text = "Name Product";
            // 
            // btn_refresh
            // 
            this.btn_refresh.BackColor = System.Drawing.Color.White;
            this.btn_refresh.Font = new System.Drawing.Font("Bernard MT Condensed", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_refresh.Location = new System.Drawing.Point(593, 320);
            this.btn_refresh.Name = "btn_refresh";
            this.btn_refresh.Size = new System.Drawing.Size(75, 23);
            this.btn_refresh.TabIndex = 100;
            this.btn_refresh.Text = "Refresh";
            this.btn_refresh.UseVisualStyleBackColor = false;
            this.btn_refresh.Click += new System.EventHandler(this.btn_refresh_Click);
            // 
            // FrmPRoduct
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(789, 350);
            this.Controls.Add(this.btn_refresh);
            this.Controls.Add(this.txt_price);
            this.Controls.Add(this.label_price);
            this.Controls.Add(this.txt_quantity);
            this.Controls.Add(this.txt_name_pro);
            this.Controls.Add(this.txt_reference);
            this.Controls.Add(this.label_Quantity);
            this.Controls.Add(this.label_reference_pro);
            this.Controls.Add(this.label_name_pro);
            this.Controls.Add(this.btn_print);
            this.Controls.Add(this.btn_save_pro);
            this.Controls.Add(this.listView_product);
            this.Controls.Add(this.label_list);
            this.Controls.Add(this.btn_delete_pro);
            this.Controls.Add(this.btn_edit_pro);
            this.Controls.Add(this.btn_add_pro);
            this.Name = "FrmPRoduct";
            this.Text = "FrmPRoduct";
            this.Load += new System.EventHandler(this.FrmPRoduct_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_save_pro;
        private System.Windows.Forms.ListView listView_product;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.ColumnHeader columnHeader6;
        private System.Windows.Forms.Label label_list;
        private System.Windows.Forms.Button btn_delete_pro;
        private System.Windows.Forms.Button btn_edit_pro;
        private System.Windows.Forms.Button btn_add_pro;
        private System.Windows.Forms.Button btn_print;
        private System.Windows.Forms.TextBox txt_price;
        private System.Windows.Forms.Label label_price;
        private System.Windows.Forms.TextBox txt_quantity;
        private System.Windows.Forms.TextBox txt_name_pro;
        private System.Windows.Forms.TextBox txt_reference;
        private System.Windows.Forms.Label label_Quantity;
        private System.Windows.Forms.Label label_reference_pro;
        private System.Windows.Forms.Label label_name_pro;
        private System.Windows.Forms.Button btn_refresh;
    }
}