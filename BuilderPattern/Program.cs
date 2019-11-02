using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuilderPattern
{
    class Program
    {
        /// <summary>
        /// 建造者模式：
        /// 建造者模式分为：1.指挥者；2.建造者
        /// 指挥者直接跟客户端打交道，拿到客户端的请求后，再交给指定的建造者去响应这个请求
        /// 举例为：
        /// 公司老板跟客户打交道，客户需要java项目，.net项目，Python项目，php项目等等...
        /// 老板从客户那里接到需求后，再交给公司指定语言开发者去开发，然后交付
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            //初始化老板：可以理解为成立公司（指挥者）
            Boss boss = new Boss();

            //初始化java开发：可以理解为公司招聘了一个java开发（建造者）
            Programmer javaProgrammer = new JavaProgrammer();
            //初始化.Net开发：可以理解为公司招聘了一个.Net开发（建造者）
            Programmer netProgrammer = new NetProgrammer();

            //这个时候来了一个java项目，老板让java开发去做
            boss.MakeProject(javaProgrammer);
            //这个时候又来了一个.Net项目，老板让.Net开发去做
            boss.MakeProject(netProgrammer);

            Console.WriteLine("End");
            Console.ReadKey();
        }
    }
}
