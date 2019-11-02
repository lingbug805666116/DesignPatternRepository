using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComposePattern
{
    /// <summary>
    /// 电脑产品
    /// </summary>
    public class Computer : Product
    {
        public Computer(string name) : base(name)
        {

        }

        private List<Product> ChildProduct = new List<Product>();

        public override void Work()
        {
            ChildProduct.ForEach(r => r.Work());
        }

        public override void Add(Product product)
        {
            ChildProduct.Add(product);
        }

        public override void Remove(Product product)
        {
            ChildProduct.Remove(ChildProduct.First(r => r.Name == product.Name));
        }
    }
}
