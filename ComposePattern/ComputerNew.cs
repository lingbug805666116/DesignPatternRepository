using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComposePattern
{
    public class ComputerNew : ProductNew, IComplexProduct
    {
        private List<ProductNew> ChildProductList = new List<ProductNew>();

        public ComputerNew(string name) : base(name)
        {

        }

        public override void Work()
        {
            ChildProductList.ForEach(r => r.Work());
        }

        public void Add(ProductNew product)
        {
            ChildProductList.Add(product);
        }

        public void Remove(ProductNew product)
        {
            ChildProductList.Remove(ChildProductList.First(r => r.Name == product.Name));
        }
    }
}
