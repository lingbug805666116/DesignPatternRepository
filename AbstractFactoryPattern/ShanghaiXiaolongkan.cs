using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactoryPattern
{
    public class ShanghaiXiaolongkan : Xiaolongkan
    {
        public override void MakeHotpot()
        {
            Console.WriteLine("上海的小龙坎，很甜，不好吃");
        }
    }
}
