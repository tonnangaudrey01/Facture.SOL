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
using Microsoft.Reporting.WinForms;

namespace Factures
{
    public partial class FrmPreview : Form
    {
        public User user;
       
        public FrmPreview(User user)
        {
            InitializeComponent();
            this.user = user;
            
        }

        private void FrmPreview_Load(object sender, EventArgs e)
        {
            this.reportViewer1.ZoomPercent = 100;
            this.reportViewer1.RefreshReport();
            this.reportViewer1.LocalReport.ReportPath = "ReportFacture.rdlc";

            List<Product> products = this.user.Products;
                
            this.reportViewer1.LocalReport.DataSources.Add
                (

                  new ReportDataSource("DataSet1", products)
                );
            ReportParameter[] para = new ReportParameter[]
            {
                new ReportParameter("name",user.Name),
                new ReportParameter("adresse", "jika akwa"),
                new ReportParameter("ville","douala"),
                new ReportParameter("téléphone","692811228"),
                new ReportParameter("doit","Monsieur"),
                new ReportParameter("nom","Tonnang"),
                new ReportParameter("prenom","russel"),
                new ReportParameter("date","23 juin 2020"),
                new ReportParameter("numéro_facture","23A"),
                new ReportParameter("code_client","251C"),
                new ReportParameter("livré","Mr donfack"),
                new ReportParameter("téléphone_client","65918265")
            };
            //List<Identification> references = new List<Identification>
            //    {
            //        new Identification("","",' ' ,"","","","","","","" ,' ', File.ReadAllBytes("onduleur.png" )),
            //        new Identification("jika akwa","douala",692811228,"Monsieur","tonnang","russel","23 juin 2020","23A","251C","Mr donfack",65918265,null),
            //        new Identification("makepe","douala",657365492,"Monsieur","kenfack","ryan","23 main 2019","01D","34A","Mr Mock",696059677,null)
            //    };
            this.reportViewer1.LocalReport.SetParameters(para);
            this.reportViewer1.SetDisplayMode(DisplayMode.PrintLayout);
        }
    }
}
