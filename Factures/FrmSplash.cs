using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Factures
{
    public partial class FrmSplash : Form
    {
        public FrmSplash()
        {
            InitializeComponent();
        }

        private void progressBar_Click(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            progressBar.PerformStep(); //Faire progresser la barre de six pas (6 step)

            if (progressBar.Value == progressBar.Maximum) //La barre est arrivée à sa fin
            {
                var form = new FrmList();
                form.Show();
                this.Close();
            }
        }

        private void FrmSplash_Load(object sender, EventArgs e)
        {
            timer1.Interval = 1000;
            timer1.Start();
        }
    }
}
