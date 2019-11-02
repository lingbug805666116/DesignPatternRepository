using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecoratePattern
{
    /// <summary>
    /// 这个是我本人，我也是人类，所以要继承人类
    /// </summary>
    public class Lingbug : Person
    {
        public override void Develop()
        {
            //原来我只会.Net开发
            Console.WriteLine("我会开发.Net程序！");
        }
    }
}
