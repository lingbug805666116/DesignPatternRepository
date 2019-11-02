using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProxyPattern
{
    /// <summary>
    /// 真实想要操作的人（客户端）
    /// </summary>
    public class NeedBuyPerson : Person
    {
        public override void Buy()
        {
            Console.WriteLine("帮我买一个iPhone 11 pro max");
        }
    }
}
