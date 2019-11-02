using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlyweightPattern
{
    class Program
    {
        /// <summary>
        /// 享元模式：
        /// 如果我们需要大量相同的对象，如果一个个去new的话，会导致很浪费资源和性能，而享元就是为了解决这个问题的
        /// 看到这里，大家脑海里肯定会想：哎，这不是原型模式吗？怎么享元模式跟原型模式一样了？
        /// 
        /// 让我来解释一下吧：
        /// 原型模式：为了避免new，而采用克隆的方式来构造对象（注重构造），原型模式是一个创建型模式，所以注重的是创建
        /// 享元模式：不仅仅是为了避免new，更多的还是为了重用一个对象（注重重用），它的一些属性我们是可以直接用的。
        ///
        /// 此文中的例子：大头儿子一家
        /// 假如大头儿子一家三口，家里有两辆车，一辆白色，一辆黑色，然后家里每次出行时需要开车
        /// 不可能说每一次出行都要去新买一辆车吧（new），所以只需要买一个（new一次），之后要使用，直接去车库开就好了
        /// 如果家里的车不够了，假如大头儿子长大了，想要买一辆蓝色的车，此时车库里没有，则需要重新去买一辆放在车库里
        /// 以后大头儿子要开车的话就可以从车库里去开了
        ///
        /// 享元模式又分为：1.内部状态；2.外部状态；
        /// 内部状态：在享元的内部不会因为环境的改变而改变，在上述例子中车就是内部状态，只要买了就在车库，不会改变
        /// 外部状态：会随环境改变而改变，不可以享元的状态，在上述例子中大头儿子一家就是外部状态，车不会变，但是谁开车，这个是会变化的，这个无法享元
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            //不管取多少遍车，同一个颜色的车，永远只会实例化一次（买一次）
            FlyweightFactory carFactory = new FlyweightFactory();
            Car car1 = carFactory.GetCar("白色");
            Car car2 = carFactory.GetCar("黑色");
            Car car3 = carFactory.GetCar("蓝色");
            carFactory.GetCar("白色");
            carFactory.GetCar("黑色");
            carFactory.GetCar("蓝色");

            //指定外部环境（谁去开车）
            car1.Drive(new Driver("围裙妈妈"));
            car2.Drive(new Driver("小头爸爸"));
            car3.Drive(new Driver("大头儿子"));

            Console.WriteLine("End");
            Console.ReadKey();
        }
    }
}
