using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComposePattern
{
    public abstract class ProductNew
    {
        public ProductNew(string name)
        {
            this.Name = name;
        }

        public string Name { get; set; }

        public abstract void Work();
    }
}
