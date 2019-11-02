using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactoryPattern
{
    class Program
    {
        /// <summary>
        /// 抽象工厂模式：
        /// 学习了简单工厂和工厂方法之后，再来看抽象工厂，就非常简单，基本上无需写代码
        /// 工厂方法是为了创建一个单一对象，而抽象工厂就是为了创建一系列的对象
        /// 举例子我就全国不同城市的火锅吧，因为不同城市的口味是不同的
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            //上海工厂
            AbstractFactory shanghaiFactory = new ShanghaiFactory();
            //上海小龙坎
            Xiaolongkan shanghaiXiaolongkan = shanghaiFactory.CreateXiaolongkan();
            shanghaiXiaolongkan.MakeHotpot();
            //上海袁老四
            Yuanlaosi shanghaiYuanlaosi = shanghaiFactory.CreateYuanlaosi();
            shanghaiYuanlaosi.MakeHotpot();

            //重庆工厂
            AbstractFactory chongqingFactory = new ChongqingFactory();
            //重庆小龙坎
            Xiaolongkan chongqingXiaolongkan = chongqingFactory.CreateXiaolongkan();
            chongqingXiaolongkan.MakeHotpot();
            //重庆袁老四
            Yuanlaosi chongqingYuanlaosi = chongqingFactory.CreateYuanlaosi();
            chongqingYuanlaosi.MakeHotpot();

            Console.WriteLine("End");
            Console.ReadKey();
        }
    }
}
