using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Factures.BO;

namespace Factures.DAL
{
    public class UserRepository : BaseRepository<User>
    {

        public UserRepository(Mode mode, string path) : base(path, mode)
        {
        }
        public bool ProductExists(User user, Product product)
        {
            if (base.IsExists(user))
            {
                foreach (var item in user.Products)
                {
                    if (item.Equals(product))
                        return true;
                }
                return false;
            }
            else
                throw new KeyNotFoundException("utilisateur introuvable");
        }
        public void AddProduct(User user, Product product)
        {
            if (!this.ProductExists(user, product))
            {
                user.Products.Add(product);
                base.Save();
            }
            else
                throw new DuplicateWaitObjectException("product", "ce produit existe deja");
        }
        public void SetProduct(User user, Product oldProduct, Product newProduct)
        {
            if (this.ProductExists(user, oldProduct))
            {
                for (int i = 0; i < user.Products.Count; i++)
                {
                    if (user.Products[i].Equals(oldProduct))
                    {
                        user.Products[i] = newProduct;
                        base.Save();
                    }
                }
            }
            else
                throw new KeyNotFoundException("produit introuvable");
        }
        public void DeleteProduct(User user, Product product)
        {
            if (this.ProductExists(user, product))
            {
                int index = 0;
                for (int i = 0; i < user.Products.Count; i++)
                {
                    if (user.Products[i].Equals(product))
                        index = i;
                }
                user.Products.RemoveAt(index);
                base.Save();
            }
            else
                throw new KeyNotFoundException("produit introuvable");
        }
        public Product GetProductById(User user, string id)
        {
            if (base.IsExists(user))
            {
                foreach (var item in user.Products)
                {
                    if (item.Id == id)
                        return item;
                }
                throw new KeyNotFoundException("produit introuvable");
            }
            else
                throw new KeyNotFoundException("utilisateur introuvable");
        }
        public int IndexOfProduct(User user, string idProduct)
        {
            if (base.IsExists(user))
            {
                for (int i = 0; i < user.Products.Count; i++)
                {
                    if (user.Products[i].Id == idProduct)
                        return i;
                }
                throw new KeyNotFoundException("produit introuvable");
            }
            else
                throw new KeyNotFoundException("utilisateur introuvable");
        }
    }
}
