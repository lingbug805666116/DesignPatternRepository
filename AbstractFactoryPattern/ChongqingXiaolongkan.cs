using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactoryPattern
{
    public class ChongqingXiaolongkan : Xiaolongkan
    {
        public override void MakeHotpot()
        {
            Console.WriteLine("重庆的小龙坎，很辣，好吃刺激");
        }
    }
}
