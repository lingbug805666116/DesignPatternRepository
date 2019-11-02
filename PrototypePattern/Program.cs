using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrototypePattern
{
    class Program
    {
        /// <summary>
        /// 原型模式：
        /// 在程序运行当中，如果不停的new一个对象的话，数量太多的多会导致太多的内存占用，继而浪费空间
        /// 使用原型模式，如果我们需要一个对象，可以将原来已经实例化过的对象进行一次拷贝，
        /// 就不会去浪费内存空间和构造的时间（如果构造函数耗时原型模式很实用）
        /// 分为浅拷贝和深拷贝
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            Stopwatch watch = new Stopwatch();
            try
            {
                watch.Start();
                //TestMake();
                //TestClone();
                TestDeepClone();
            }
            catch (Exception e)
            {
                Console.WriteLine("Error：" + e.Message);
            }
            watch.Stop();
            Console.WriteLine("耗时：" + watch.Elapsed);
            Console.WriteLine("End");
            Console.ReadKey();
        }

        private static void TestMake()
        {
            Boy user1 = new Boy("1", "2", 18, new List<string>() { "3", "test" }, DateTime.Now, new ClassModel() { ClassId = 1, ClassName = "一班" });
            Boy user2 = new Boy("2", "3", 20, new List<string>() { "role", "6" }, DateTime.Now.AddHours(-66), new ClassModel() { ClassId = 3, ClassName = "三班" });
        }

        private static void TestClone()
        {
            Boy user1 = new Boy("1", "2", 18, new List<string>() { "3", "test" }, DateTime.Now, new ClassModel() { ClassId = 1, ClassName = "一班" });
            Boy user2 = user1.Clone() as Boy;
            Console.WriteLine(user1 == user2);
            user2.Roles.Add("111");
            //浅拷贝：内存地址一样，修改其中的引用类型，会导致所有拷贝的原型都被修改
            Console.WriteLine("user1.role = " + user1.Roles.Count);//3
            Console.WriteLine("user2.role = " + user2.Roles.Count);//3
        }

        private static void TestDeepClone()
        {
            Boy user1 = new Boy("1", "2", 18, new List<string>() { "3", "test" }, DateTime.Now, new ClassModel() { ClassId = 1, ClassName = "一班" });
            Boy user2 = user1.DeepClone() as Boy;
            Console.WriteLine(user1 == user2);
            user2.Roles.Add("111");
            //深拷贝：完全拷贝，将内部的引用对象也都拷贝一次，修改不会影响其原始值
            //注意：深拷贝必须内部所有引用对象全部都标记Serializable特性（在此例中需要标记User，Boy，ClassModel为Serializable）
            Console.WriteLine("user1.role = " + user1.Roles.Count);//2
            Console.WriteLine("user2.role = " + user2.Roles.Count);//3
        }
    }
}
