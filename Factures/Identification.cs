using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Factures
{
   public class Identification
    {
        public string Adresse { get; set; }
        public string Ville { get; set; }
        public int Téléphone { get; set; }
        public string Doit { get; set; }
        public string Nom { get; set; }
        public string Prénom { get; set; }
        public string Date { get; set; }
        public string Numero_FactureN { get; set; }
        public string Code_client { get; set; }
        public string Livré { get; set; }
        public int Téléphone_Client { get; set; }
        public byte[] Logo { get; set; }
        public List<Identification> identifications { get; set; }

        public Identification(string adresse, string ville, int téléphone, string doit, string nom, string prénom, string date, string numero_FactureN, string code_client, string livré, int téléphone_Client, byte[] logo)
        {
            Adresse = adresse;
            Ville = ville;
            Téléphone = téléphone;
            Doit = doit;
            Nom = nom;
            Prénom = prénom;
            Date = date;
            Numero_FactureN = numero_FactureN;
            Code_client = code_client;
            Livré = livré;
            Téléphone_Client = téléphone_Client;
            Logo = logo;
        }

        public Identification()
        {
            identifications = new List<Identification>();

        }

        public Identification(Identification reference) : this(reference?.Adresse, reference?.Ville, reference.Téléphone, reference?.Doit, reference?.Nom, reference?.Prénom, reference?.Date, reference?.Numero_FactureN, reference?.Code_client, reference?.Livré, reference.Téléphone_Client, reference.Logo)
        {

        }

        

       
    }
}
