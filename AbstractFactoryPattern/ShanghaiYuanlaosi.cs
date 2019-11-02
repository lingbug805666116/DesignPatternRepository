using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactoryPattern
{
    public class ShanghaiYuanlaosi : Yuanlaosi
    {
        public override void MakeHotpot()
        {
            Console.WriteLine("上海的袁老四，甜的，不好吃");
        }
    }
}
