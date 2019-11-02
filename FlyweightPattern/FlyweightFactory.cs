using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Core;

namespace FlyweightPattern
{
    /// <summary>
    /// 享元工厂：类似于车库
    /// </summary>
    public class FlyweightFactory
    {
        /// <summary>
        /// 这里真实场景需要考虑到现场安全问题
        /// 解决办法：1.lock；2.线程安全数据类型：ConcurrentDictionary；3.原子操作
        /// 这里的Dictionary，在java里面相当于map，java开发者可以这样理解
        /// 我这里使用lock，因为lock在C#和java都有，方便大家理解
        /// </summary>
        private Dictionary<string, Car> CarContainer = new Dictionary<string, Car>();

        /// <summary>
        /// 我这里使用lock防止并发，因为lock在C#和java都有，方便大家理解
        /// readonly关键字此时相当于java的final关键字
        /// </summary>
        private static readonly object CarLocker = new object();

        public FlyweightFactory()
        {
            //最开始家里有两辆车，一辆白色，一辆黑色
            this.CarContainer.Add("白色", new Car("白色"));
            this.CarContainer.Add("黑色", new Car("黑色"));
        }

        /// <summary>
        /// 从车库取车操作
        /// </summary>
        /// <returns></returns>
        public Car GetCar(string color)
        {
            Car car = null;
            CoreService.RunLock(CarLocker, () =>
            {
                //判断车库里面有没有这个颜色的车
                if (CarContainer.ContainsKey(color))
                {
                    Console.WriteLine("车库里有{0}的车，直接从车库取走", color);
                    //有这个颜色的就直接取车
                    car = CarContainer[color];
                }
                else
                {
                    Console.WriteLine("车库里没有{0}的车，去买一辆放在车库，然后取走", color);
                    //没有的话，就买一辆新的，放在车库
                    CarContainer.Add(color, new Car(color));
                    //然后取出去，下次就不用买了，可以直接取
                    car = CarContainer[color];
                }
            });
            return car;
        }
    }
}
