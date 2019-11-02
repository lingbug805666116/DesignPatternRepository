using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleFactoryPattern
{
    class Program
    {
        /// <summary>
        /// 模拟使用简单工厂的场景介绍：
        /// 比如吃饭，想要吃什么菜都得自己去炒，我自己得全方位照顾到，这是单纯的需要什么去做什么
        /// 使用简单工厂的思路就是：
        /// 我要吃饭，我去饭馆吃，我想要吃什么我点菜，饭馆给我做就好了，至于怎么做是饭馆的事（此时饭馆就相当于简单工厂）
        /// 相当于把做饭的细节从我身上推迟给饭馆
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            try
            {
                //TestNormal();
                TestSimpleFactory();
            }
            catch (Exception e)
            {
                Console.WriteLine("Error：" + e.Message);
            }
            Console.WriteLine("End");
            Console.ReadKey();
        }

        private static void TestNormal()
        {
            //不使用简单工厂，都是顾客自己来
            //所有的业务代码（如何做饭）都写在顾客类中，导致程序耦合性变高，扩展性变低
            Food food1 = Customer.MakeFood(FoodType.Patato);
            food1.Make();
            Food food2 = Customer.MakeFood(FoodType.Chicken);
            food2.Make();
            Food food3 = Customer.MakeFood(FoodType.TomatoWithEggs);
            food3.Make();
        }

        private static void TestSimpleFactory()
        {
            //使用简单工厂，客户直接去点菜就可以（自己不用操心如何做菜）
            //后续扩展直接实现抽象类就可以，低耦合，易扩展
            Food food1 = SimpleFactory.MakeFood(FoodType.Patato);
            food1.Make();
            Food food2 = SimpleFactory.MakeFood(FoodType.Chicken);
            food2.Make();
            Food food3 = SimpleFactory.MakeFood(FoodType.TomatoWithEggs);
            food3.Make();
        }
    }
}
