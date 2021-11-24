using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Factures.BO;
using Factures.DAL;

namespace Factures
{
    public partial class FrmPRoduct : Form
    {
        public User USER;
        public string PATH;
        public DirectoryInfo dir = Directory.CreateDirectory("audrey");
        public FrmPRoduct(User user)
        {
            InitializeComponent();
            this.USER = user;
            this.PATH = Path.Combine(dir.FullName, "audrey.txt");
        }

        private void FrmPRoduct_Load(object sender, EventArgs e)
        {
            if (File.Exists(PATH))
            {
                
                foreach (var item in this.USER.Products)
                {
                    ListViewItem lv = listView_product.Items.Add(item.Name);
                    lv.SubItems.Add(item.Id);
                    lv.SubItems.Add(item.Qunatity.ToString());
                    lv.SubItems.Add(item.Price.ToString());
                }
            }
        }

        private void btn_print_Click(object sender, EventArgs e)
        {
            var form = new FrmPreview(this.USER);
            form.Show();
        }

        private void btn_add_pro_Click(object sender, EventArgs e)
        {
            UserRepository userRepository = new UserRepository(Mode.Binary, this.PATH);
            User user = this.USER;
            Product product = new Product(txt_reference.Text, txt_name_pro.Text, int.Parse(txt_quantity.Text), double.Parse(txt_price.Text));
            user.Products.Add(product);
            MessageBox.Show("Produit ajouté avec succès !");
        }

        private void btn_refresh_Click(object sender, EventArgs e)
        {
            listView_product.Items.Clear();
            if (File.Exists(PATH))
            {

                foreach (var item in this.USER.Products)
                {
                    ListViewItem lv = listView_product.Items.Add(item.Name);
                    lv.SubItems.Add(item.Id);
                    lv.SubItems.Add(item.Qunatity.ToString());
                    lv.SubItems.Add(item.Price.ToString());
                }
            }
        }

        private void btn_edit_pro_Click(object sender, EventArgs e)
        {
            if (listView_product.SelectedItems.Count > 0)
            {
                UserRepository userRepository = new UserRepository(Mode.Binary, this.PATH);
                User newUser = userRepository.FindById(this.USER.Id);
                txt_name_pro.Text = listView_product.SelectedItems[0].Text;
                txt_reference.Text = listView_product.SelectedItems[0].SubItems[1].Text;
                txt_quantity.Text = listView_product.SelectedItems[0].SubItems[1].Text;
                txt_price.Text = listView_product.SelectedItems[0].SubItems[1].Text;
            }

            else
                MessageBox.Show("Veuillez selectionner un produit !");
        }

        private void btn_delete_pro_Click(object sender, EventArgs e)
        {
            if (listView_product.SelectedItems.Count > 0)
            {
                UserRepository userRepository = new UserRepository(Mode.Binary, this.PATH);
                User user = userRepository.FindById(this.USER.Id);
                User oldUser = user;

                Product product1 = userRepository.GetProductById(user, txt_reference.Text);
                userRepository.DeleteProduct(user, product1);
                userRepository.Set(oldUser, user);
            }
            else
                MessageBox.Show("Veuillez selectionner un produit !");
        }

        private void btn_save_pro_Click(object sender, EventArgs e)
        {
            UserRepository userRepository = new UserRepository(Mode.Binary, this.PATH);
            User user = userRepository.FindById(this.USER.Id);
            User oldUser = user;
            Product product = new Product(txt_reference.Text, txt_name_pro.Text, int.Parse(txt_quantity.Text), double.Parse(txt_price.Text));
            Product product1 = userRepository.GetProductById(user, txt_reference.Text);
            userRepository.SetProduct(user, product1, product);
            userRepository.Set(oldUser, user);
        }
    }
}
