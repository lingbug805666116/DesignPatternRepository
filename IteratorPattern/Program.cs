using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IteratorPattern
{
    class Program
    {
        /// <summary>
        /// 迭代器模式：
        /// 顾名思义，迭代器模式就是可以对一个集合进行迭代循环遍历
        /// 所以一个集合可以循环遍历，肯定是有两部分构成：1.集合本身；2.迭代器对象；
        ///
        /// 根据设计模式六大原则的单一职责：
        /// 我们应该将集合和迭代器这两部分解耦分离开
        /// 所以此时我们需要定义两个接口：1.集合本身；2.迭代器；
        /// 然后每个对象都要有具体的实现，这样子就应该有4个对象
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            //初始化数据对象
            Data data = new Data(new int[] { 1, 9, 6, 2, 8, 33, 44, 66, 88, 65, 2123, 78, 9 });
            //获取到数据对象的迭代器
            ITerator iterator = data.GetIterator();
            //遍历输出数据值
            while (iterator.MoveNext())
            {
                var value = iterator.GetCurrent();
                Console.WriteLine(value.ToString());
                iterator.Next();
            }
            Console.WriteLine("End");
            Console.ReadKey();
        }
    }
}
