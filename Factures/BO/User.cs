using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Factures.BO
{
    [Serializable]
   public class User:BaseModel
    {
        public string Password { get; set; }
        public List<Product> Products;
        public User()
        {

        }
        public User(string email, string name, string password) :base(email,name)
        {
            this.Products = new List<Product>();
            this.Password = password;
        }

        public User(string email, string name, string password,List<Product>products):this(email,name,password)
        {
            this.Products = products;
        }
    }
}
