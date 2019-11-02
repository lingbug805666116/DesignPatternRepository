using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SingletonPattern
{
    public sealed class SingletonStatic
    {
        private SingletonStatic() { }

        private static SingletonStatic _Instance = null;

        //利用静态构造函数的特性：在第一次使用该类时会有且仅有调用一次该静态构造函数，这样可以达到单例的效果
        static SingletonStatic()
        {
            _Instance = new SingletonStatic();
            Console.WriteLine(nameof(SingletonStatic) + "实例化了");
        }

        public static SingletonStatic Instance
        {
            get
            {
                return _Instance;
            }
        }
    }
}
