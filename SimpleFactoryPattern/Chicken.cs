using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleFactoryPattern
{
    public class Chicken : Food
    {
        public override void Make()
        {
            Console.WriteLine("鸡肉做好了！");
        }
    }
}
