using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Factures.BO
{
    [Serializable]
    public class BaseModel
    {
        public string Id { get; set; }
        public string Name { get; set; }
        public BaseModel()
        {

        }
        public BaseModel(string id, string name)
        {
            this.Id = id;
            this.Name = name;
        }
    }
}
