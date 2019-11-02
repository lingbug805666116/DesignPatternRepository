using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComposePattern
{
    /// <summary>
    /// 产品类
    /// </summary>
    public abstract class Product
    {
        public Product(string name)
        {
            this.Name = name;
        }

        public string Name { get; set; }

        /// <summary>
        /// 每个产品都可以工作
        /// </summary>
        public abstract void Work();

        /// <summary>
        /// 每个产品都可以往里面再添加子产品
        /// 至于有些产品不能再添加子产品，这里我们一会会详细说，大家先记住这一点
        /// </summary>
        public abstract void Add(Product product);

        /// <summary>
        /// 每个产品都可以移除子产品，同上
        /// </summary>
        public abstract void Remove(Product product);
    }
}
