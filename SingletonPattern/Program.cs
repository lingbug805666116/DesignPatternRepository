using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Core;

namespace SingletonPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                //TestFirst();
                //TestSecond();
                //TestThird();
                TestStatic();
            }
            catch (Exception e)
            {
                Console.WriteLine("发生异常：" + e.Message);
            }
            Console.WriteLine("End");
            Console.ReadKey();
        }

        private static void TestFirst()
        {
            for (int i = 1; i <= 100; i++)
            {
                Task.Run(() =>
                {
                    var instance = SingletonFirst.Instance;
                });
            }
        }

        private static void TestSecond()
        {
            for (int i = 1; i <= 100; i++)
            {
                Task.Run(() =>
                {
                    var instance = SingletonSecond.Instance;
                });
            }
        }

        private static void TestThird()
        {
            for (int i = 1; i <= 100; i++)
            {
                Task.Run(() =>
                {
                    var instance = SingletonThird.Instance;
                });
            }
        }

        private static void TestStatic()
        {
            for (int i = 1; i <= 100; i++)
            {
                Task.Run(() =>
                {
                    var instance = SingletonStatic.Instance;
                });
            }
        }
    }
}
