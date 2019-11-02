using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComposePattern
{
    /// <summary>
    /// CPU产品
    /// </summary>
    public class Cpu : Product
    {
        public Cpu(string name) : base(name)
        {

        }

        public override void Work()
        {
            Console.WriteLine("Cpu工作啦！");
        }

        /// <summary>
        /// 由于CPU已经是很小的零件了，不能再有子零件，所有不会有添加和删除的方法，所以先模拟抛出异常
        /// 这里大家先这么看，后续我们会详细讲解这里
        /// </summary>
        /// <param name="product"></param>
        public override void Add(Product product)
        {
            Console.WriteLine("不能给CPU添加子产品！");
        }

        public override void Remove(Product product)
        {
            Console.WriteLine("不能给CPU移除子产品！");
        }
    }
}
