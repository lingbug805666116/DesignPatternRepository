using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProxyPattern
{
    /// <summary>
    /// 代理对象
    /// </summary>
    public class ProxyPerson : Person
    {
        public override void Buy()
        {
            Console.WriteLine("大家好，我是代购");
            Console.WriteLine("代购买之前的操作：我需要将这次需要帮忙买的清单列一下...");
            Person needBuyPerson = new NeedBuyPerson();
            needBuyPerson.Buy();
            Console.WriteLine("代购买之后的操作：我需要将买的东西核对检查一下...");
        }
    }
}
