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
    public partial class FrmList : Form
    {
        public DirectoryInfo dir = Directory.CreateDirectory("audrey");
        public string PATH;
        public FrmList()
        {
            InitializeComponent();
            this.PATH = Path.Combine(dir.FullName, "audrey.txt");
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Refreshh();
        }

        private void Refreshh()
        {
            if (File.Exists(this.PATH))
            {
                //pour avoir tous les element du fichier
                List<User> users = new UserRepository(Mode.Binary, this.PATH).GetAll();
                foreach (var item in users)
                {
                    ListViewItem lv = listView_user_list.Items.Add(item.Name);
                    lv.SubItems.Add(item.Id);
                }
            }
        }

        private void btn_add_Click(object sender, EventArgs e)
        {
            if (txt_name.Text == "" || txt_email.Text == "" || txt_password.Text == "")
                MessageBox.Show("Un champ est vide veuillez remplir");
            else
            {
                User user = new User(txt_email.Text, txt_name.Text, txt_password.Text);
                UserRepository repository = new UserRepository(Mode.Binary, this.PATH);
                repository.Add(user);
                MessageBox.Show("Utilisateur ajouté avec succès");
            }
        }

        private void btn_edit_user_Click(object sender, EventArgs e)
        {
            if (listView_user_list.SelectedItems.Count > 0)
            {
                txt_name.Text = listView_user_list.SelectedItems[0].Text;
                txt_email.Text = listView_user_list.SelectedItems[0].SubItems[1].Text;
                UserRepository repository = new UserRepository(Mode.Binary, this.PATH);
                string id = listView_user_list.SelectedItems[0].SubItems[1].Text;
                User user = repository.FindById(id);
                txt_password.Text = user.Password;
            }
            else
            {
                MessageBox.Show("veuillez selectionner un élément");
            }
        }

        private void btn_delete_user_Click(object sender, EventArgs e)
        {
            if (listView_user_list.SelectedItems.Count > 0)
            {
                UserRepository userRepository = new UserRepository(Mode.Binary, this.PATH);
                string id = listView_user_list.SelectedItems[0].SubItems[1].Text;
                User user = userRepository.FindById(id);
                userRepository.Delete(user);
            }
        }

        private void btn_refresh_Click(object sender, EventArgs e)
        {
            listView_user_list.Items.Clear();
            Refreshh();
        }

        private void btn_suivant_Click(object sender, EventArgs e)
        {
            if (listView_user_list.SelectedItems.Count > 0)
            {
                string id = listView_user_list.SelectedItems[0].SubItems[1].Text;
                User user = new UserRepository(Mode.Binary, this.PATH).FindById(id);
                var form = new FrmPRoduct(user);
                form.Show();
                this.Close();
            }
            else
                MessageBox.Show("Veuillez selectionner un utilisateur ");

        }

        private void btn_print_Click(object sender, EventArgs e)
        {
            if (listView_user_list.SelectedItems.Count > 0)
            {
                string id = listView_user_list.SelectedItems[0].SubItems[1].Text;
                User user = new UserRepository(Mode.Binary, this.PATH).FindById(id);
                var form = new FrmPreview(user);
                form.Show();
            }

            else
                MessageBox.Show("Veuillez selectionner un utilisateur !");
        }

        private void txt_search_TextChanged(object sender, EventArgs e)
        {
            if (File.Exists("audrey.txt"))
            {
                List<string> list = new List<string>();
                using (StreamReader sr = new StreamReader("audrey.txt"))
                {
                    string[] tab = sr.ReadLine().Split('|');
                    for (int i = 0; i < tab.Length; i++)
                    {
                        list.Add(tab[i]);
                    }
                }
                List<string> search = new List<string>();
                for (int i = 0; i < list.Count; i += 3)
                {
                    if (list[i].Contains(txt_search.Text))
                    {
                        search.Add(list[i]);
                    }
                }
                foreach (var item in search)
                {
                    ListViewItem item1;
                    item1 = listView_search.Items.Add(item);
                }
            }
        }

        private void btn_save_user_Click(object sender, EventArgs e)
        {
            try
            {
                var user = new User(txt_name.Text, txt_email.Text, txt_password.Text);
                User user1 = new UserRepository(Mode.Binary, this.PATH).FindById(txt_email.Text);
                new UserRepository(Mode.Binary, this.PATH).Set(user1, user);
                MessageBox.Show("Modification réussi !");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
