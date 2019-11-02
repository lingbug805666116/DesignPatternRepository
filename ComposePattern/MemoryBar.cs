using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComposePattern
{
    /// <summary>
    /// 内存条产品
    /// </summary>
    public class MemoryBar : Product
    {
        public MemoryBar(string name) : base(name)
        {

        }

        public override void Work()
        {
            Console.WriteLine("内存条工作啦！");
        }

        public override void Add(Product product)
        {
            Console.WriteLine("不能给内存条添加子产品！");
        }

        public override void Remove(Product product)
        {
            Console.WriteLine("不能给内存条移除子产品！");
        }
    }
}
