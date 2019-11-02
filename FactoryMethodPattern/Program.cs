using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethodPattern
{
    /// <summary>
    /// 工厂方法模式：
    /// 在简单工厂模式中，我们需要吃什么菜，由最开始的自己做，到后面的将如何做推迟到简单工厂中
    /// 也就是饭馆做什么菜，还是需要听我们的，我们说做啥菜，饭馆给我们做啥菜，如果要加新菜，需要饭馆去加，有点麻烦
    /// 在工厂方法模式中，我们点的菜由哪个饭馆做，可以由我们自己定义，
    /// 比如A饭馆有土豆和西红柿炒蛋，我要吃西红柿炒蛋或者土豆就让A做
    /// 但是我要吃鸡肉，只有C饭馆有，此时我就可以让C去给我做
    /// 这就是所谓的具体哪个饭馆做，由我来定义，
    /// 每个饭馆都是一个工厂，具体需要哪个工厂，由我来定义
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            TestFactoryMethod();
            Console.WriteLine("End");
            Console.ReadKey();
        }

        private static void TestFactoryMethod()
        {
            //初始化工厂方法
            PatatoFactoryCreator patatoFactory = new PatatoFactoryCreator();
            TomatoWithEggsFactoryCreator tomatoWithEggsFactory = new TomatoWithEggsFactoryCreator();
            ChickenFactoryCreator chickenFactory = new ChickenFactoryCreator();

            //通过工厂方法去创建工厂
            Food food1 = patatoFactory.CreateFactory();
            food1.Make();
            Food food2 = tomatoWithEggsFactory.CreateFactory();
            food2.Make();
            Food food3 = chickenFactory.CreateFactory();
            food3.Make();
        }
    }
}
