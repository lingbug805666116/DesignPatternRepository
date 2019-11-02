using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecoratePattern
{
    class Program
    {
        /// <summary>
        /// 装饰者模式：
        /// 1.如果想要为一类对象添加新的功能，有两种方法：
        /// ①开发新的类去继承原来的来，来扩展新的方法，缺点：会导致子类繁多
        /// ②使用装饰者模式去装饰员原来的对象
        /// 此文中的例子：
        /// 我原来只会.Net开发，现在我学会了.Net core的开发，也学会了java开发，就需要将新学会的两个技能添加到我的身上
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            //实例化我
            Person lingbug = new Lingbug();
            lingbug.Develop();//以前的我开发只会.Net开发

            Console.WriteLine("--------------------------------------------");

            //我学会了.Net core，装饰我：将.Net core加到我身上
            Person netCoreDecorator = new NetCoreDecorator(lingbug);
            netCoreDecorator.Develop();

            Console.WriteLine("--------------------------------------------");

            //我学会了java，装饰我：将java加到我身上
            Person javaDecorator = new JavaDecorator(lingbug);
            javaDecorator.Develop();

            Console.WriteLine("--------------------------------------------");

            //我学会了java和.Net core，装饰我：将java和.Net core都加到我身上
            var allDecorator = new JavaDecorator(netCoreDecorator);
            allDecorator.Develop();

            Console.WriteLine("--------------------------------------------");

            //其实可以不用实例化新的对象，一直修改最初始的那个人也是可以的（因为都是Person类），也是最符合业务逻辑的
            Person lingbugNew = new Lingbug();
            lingbugNew.Develop();

            Console.WriteLine("--------------------------------------------");

            lingbugNew = new NetCoreDecorator(lingbugNew);
            lingbugNew.Develop();

            Console.WriteLine("--------------------------------------------");

            lingbugNew = new JavaDecorator(lingbugNew);
            lingbugNew.Develop();

            Console.WriteLine("--------------------------------------------");

            Console.WriteLine("End");
            Console.ReadKey();
        }
    }
}
