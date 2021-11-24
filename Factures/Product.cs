using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Factures.BO;

namespace Factures
{
    [Serializable]
    public class Product:BaseModel
    {
        public int Qunatity { get; set; }
        public double Price { get; set; }

        public Product()
        {

        }
        public Product(string reference,string name, int quantity,double price):base(reference,name)
        {
            this.Qunatity = quantity;
            this.Price = price;
        }
    }
}
