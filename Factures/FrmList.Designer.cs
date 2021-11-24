
namespace Factures
{
    partial class FrmList
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmList));
            this.btn_print = new System.Windows.Forms.Button();
            this.listView_user_list = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.label_user_list = new System.Windows.Forms.Label();
            this.listView_search = new System.Windows.Forms.ListView();
            this.columnHeader_name = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.txt_search = new System.Windows.Forms.TextBox();
            this.btn_delete_user = new System.Windows.Forms.Button();
            this.btn_edit_user = new System.Windows.Forms.Button();
            this.btn_add = new System.Windows.Forms.Button();
            this.btn_save_user = new System.Windows.Forms.Button();
            this.txt_password = new System.Windows.Forms.TextBox();
            this.txt_email = new System.Windows.Forms.TextBox();
            this.label_password = new System.Windows.Forms.Label();
            this.label_email = new System.Windows.Forms.Label();
            this.label_name = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_name = new System.Windows.Forms.TextBox();
            this.btn_refresh = new System.Windows.Forms.Button();
            this.btn_suivant = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btn_print
            // 
            this.btn_print.BackColor = System.Drawing.Color.White;
            this.btn_print.Font = new System.Drawing.Font("Bernard MT Condensed", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_print.Location = new System.Drawing.Point(880, 337);
            this.btn_print.Name = "btn_print";
            this.btn_print.Size = new System.Drawing.Size(75, 23);
            this.btn_print.TabIndex = 75;
            this.btn_print.Text = "Print";
            this.btn_print.UseVisualStyleBackColor = false;
            this.btn_print.Click += new System.EventHandler(this.btn_print_Click);
            // 
            // listView_user_list
            // 
            this.listView_user_list.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2});
            this.listView_user_list.GridLines = true;
            this.listView_user_list.HideSelection = false;
            this.listView_user_list.Location = new System.Drawing.Point(537, 153);
            this.listView_user_list.Name = "listView_user_list";
            this.listView_user_list.Size = new System.Drawing.Size(362, 140);
            this.listView_user_list.TabIndex = 74;
            this.listView_user_list.UseCompatibleStateImageBehavior = false;
            this.listView_user_list.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Name";
            this.columnHeader1.Width = 129;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Email";
            this.columnHeader2.Width = 254;
            // 
            // label_user_list
            // 
            this.label_user_list.AutoSize = true;
            this.label_user_list.Location = new System.Drawing.Point(541, 137);
            this.label_user_list.Name = "label_user_list";
            this.label_user_list.Size = new System.Drawing.Size(50, 13);
            this.label_user_list.TabIndex = 73;
            this.label_user_list.Text = "UsersList";
            // 
            // listView_search
            // 
            this.listView_search.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader_name});
            this.listView_search.GridLines = true;
            this.listView_search.HideSelection = false;
            this.listView_search.Location = new System.Drawing.Point(523, 66);
            this.listView_search.Name = "listView_search";
            this.listView_search.Size = new System.Drawing.Size(397, 125);
            this.listView_search.TabIndex = 70;
            this.listView_search.UseCompatibleStateImageBehavior = false;
            this.listView_search.View = System.Windows.Forms.View.Details;
            this.listView_search.Visible = false;
            // 
            // columnHeader_name
            // 
            this.columnHeader_name.Text = "Name";
            this.columnHeader_name.Width = 197;
            // 
            // txt_search
            // 
            this.txt_search.Location = new System.Drawing.Point(570, 35);
            this.txt_search.Multiline = true;
            this.txt_search.Name = "txt_search";
            this.txt_search.Size = new System.Drawing.Size(350, 39);
            this.txt_search.TabIndex = 69;
            this.txt_search.TextChanged += new System.EventHandler(this.txt_search_TextChanged);
            // 
            // btn_delete_user
            // 
            this.btn_delete_user.BackColor = System.Drawing.Color.White;
            this.btn_delete_user.Font = new System.Drawing.Font("Bernard MT Condensed", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_delete_user.Location = new System.Drawing.Point(190, 259);
            this.btn_delete_user.Name = "btn_delete_user";
            this.btn_delete_user.Size = new System.Drawing.Size(90, 23);
            this.btn_delete_user.TabIndex = 68;
            this.btn_delete_user.Text = "Delete User";
            this.btn_delete_user.UseVisualStyleBackColor = false;
            this.btn_delete_user.Click += new System.EventHandler(this.btn_delete_user_Click);
            // 
            // btn_edit_user
            // 
            this.btn_edit_user.BackColor = System.Drawing.Color.White;
            this.btn_edit_user.Font = new System.Drawing.Font("Bernard MT Condensed", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_edit_user.Location = new System.Drawing.Point(100, 261);
            this.btn_edit_user.Name = "btn_edit_user";
            this.btn_edit_user.Size = new System.Drawing.Size(67, 23);
            this.btn_edit_user.TabIndex = 67;
            this.btn_edit_user.Text = "Edit User";
            this.btn_edit_user.UseVisualStyleBackColor = false;
            this.btn_edit_user.Click += new System.EventHandler(this.btn_edit_user_Click);
            // 
            // btn_add
            // 
            this.btn_add.BackColor = System.Drawing.Color.White;
            this.btn_add.Font = new System.Drawing.Font("Bernard MT Condensed", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_add.Location = new System.Drawing.Point(12, 260);
            this.btn_add.Name = "btn_add";
            this.btn_add.Size = new System.Drawing.Size(67, 24);
            this.btn_add.TabIndex = 66;
            this.btn_add.Text = "Add User";
            this.btn_add.UseVisualStyleBackColor = false;
            this.btn_add.Click += new System.EventHandler(this.btn_add_Click);
            // 
            // btn_save_user
            // 
            this.btn_save_user.BackColor = System.Drawing.Color.White;
            this.btn_save_user.Font = new System.Drawing.Font("Bernard MT Condensed", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_save_user.Location = new System.Drawing.Point(326, 256);
            this.btn_save_user.Name = "btn_save_user";
            this.btn_save_user.Size = new System.Drawing.Size(67, 28);
            this.btn_save_user.TabIndex = 62;
            this.btn_save_user.Text = "Save";
            this.btn_save_user.UseVisualStyleBackColor = false;
            this.btn_save_user.Click += new System.EventHandler(this.btn_save_user_Click);
            // 
            // txt_password
            // 
            this.txt_password.Location = new System.Drawing.Point(12, 210);
            this.txt_password.Multiline = true;
            this.txt_password.Name = "txt_password";
            this.txt_password.Size = new System.Drawing.Size(394, 23);
            this.txt_password.TabIndex = 61;
            // 
            // txt_email
            // 
            this.txt_email.Location = new System.Drawing.Point(12, 141);
            this.txt_email.Multiline = true;
            this.txt_email.Name = "txt_email";
            this.txt_email.Size = new System.Drawing.Size(394, 26);
            this.txt_email.TabIndex = 59;
            // 
            // label_password
            // 
            this.label_password.AutoSize = true;
            this.label_password.Font = new System.Drawing.Font("Bernard MT Condensed", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_password.Location = new System.Drawing.Point(9, 179);
            this.label_password.Name = "label_password";
            this.label_password.Size = new System.Drawing.Size(54, 16);
            this.label_password.TabIndex = 58;
            this.label_password.Text = "Password";
            // 
            // label_email
            // 
            this.label_email.AutoSize = true;
            this.label_email.Font = new System.Drawing.Font("Bernard MT Condensed", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_email.Location = new System.Drawing.Point(9, 108);
            this.label_email.Name = "label_email";
            this.label_email.Size = new System.Drawing.Size(34, 16);
            this.label_email.TabIndex = 57;
            this.label_email.Text = "Email";
            // 
            // label_name
            // 
            this.label_name.AutoSize = true;
            this.label_name.Font = new System.Drawing.Font("Bernard MT Condensed", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_name.Location = new System.Drawing.Point(9, 42);
            this.label_name.Name = "label_name";
            this.label_name.Size = new System.Drawing.Size(35, 16);
            this.label_name.TabIndex = 55;
            this.label_name.Text = "Name";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(527, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 13);
            this.label1.TabIndex = 54;
            this.label1.Text = "Search";
            // 
            // txt_name
            // 
            this.txt_name.Location = new System.Drawing.Point(12, 66);
            this.txt_name.Multiline = true;
            this.txt_name.Name = "txt_name";
            this.txt_name.Size = new System.Drawing.Size(394, 28);
            this.txt_name.TabIndex = 60;
            // 
            // btn_refresh
            // 
            this.btn_refresh.BackColor = System.Drawing.Color.White;
            this.btn_refresh.Font = new System.Drawing.Font("Bernard MT Condensed", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_refresh.Location = new System.Drawing.Point(718, 336);
            this.btn_refresh.Name = "btn_refresh";
            this.btn_refresh.Size = new System.Drawing.Size(75, 23);
            this.btn_refresh.TabIndex = 85;
            this.btn_refresh.Text = "Refresh";
            this.btn_refresh.UseVisualStyleBackColor = false;
            this.btn_refresh.Click += new System.EventHandler(this.btn_refresh_Click);
            // 
            // btn_suivant
            // 
            this.btn_suivant.BackColor = System.Drawing.Color.White;
            this.btn_suivant.Font = new System.Drawing.Font("Bernard MT Condensed", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_suivant.Location = new System.Drawing.Point(799, 337);
            this.btn_suivant.Name = "btn_suivant";
            this.btn_suivant.Size = new System.Drawing.Size(75, 23);
            this.btn_suivant.TabIndex = 86;
            this.btn_suivant.Text = "Suivant";
            this.btn_suivant.UseVisualStyleBackColor = false;
            this.btn_suivant.Click += new System.EventHandler(this.btn_suivant_Click);
            // 
            // FrmList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(966, 376);
            this.Controls.Add(this.btn_suivant);
            this.Controls.Add(this.btn_refresh);
            this.Controls.Add(this.btn_print);
            this.Controls.Add(this.listView_user_list);
            this.Controls.Add(this.label_user_list);
            this.Controls.Add(this.listView_search);
            this.Controls.Add(this.txt_search);
            this.Controls.Add(this.btn_delete_user);
            this.Controls.Add(this.btn_edit_user);
            this.Controls.Add(this.btn_add);
            this.Controls.Add(this.btn_save_user);
            this.Controls.Add(this.txt_password);
            this.Controls.Add(this.txt_email);
            this.Controls.Add(this.label_password);
            this.Controls.Add(this.label_email);
            this.Controls.Add(this.label_name);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txt_name);
            this.Name = "FrmList";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btn_print;
        private System.Windows.Forms.ListView listView_user_list;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.Label label_user_list;
        private System.Windows.Forms.ListView listView_search;
        private System.Windows.Forms.ColumnHeader columnHeader_name;
        private System.Windows.Forms.TextBox txt_search;
        private System.Windows.Forms.Button btn_delete_user;
        private System.Windows.Forms.Button btn_edit_user;
        private System.Windows.Forms.Button btn_add;
        private System.Windows.Forms.Button btn_save_user;
        private System.Windows.Forms.TextBox txt_password;
        private System.Windows.Forms.TextBox txt_email;
        private System.Windows.Forms.Label label_password;
        private System.Windows.Forms.Label label_email;
        private System.Windows.Forms.Label label_name;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_name;
        private System.Windows.Forms.Button btn_refresh;
        private System.Windows.Forms.Button btn_suivant;
    }
}

