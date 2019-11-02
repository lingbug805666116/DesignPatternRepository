using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactoryPattern
{
    public class ChongqingYuanlaosi : Yuanlaosi
    {
        public override void MakeHotpot()
        {
            Console.WriteLine("重庆的袁老四，很辣，好吃刺激");
        }
    }
}
