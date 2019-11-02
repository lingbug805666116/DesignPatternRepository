using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SingletonPattern
{
    public sealed class SingletonFirst
    {
        private SingletonFirst() { }

        private static SingletonFirst _Instance = null;

        public static SingletonFirst Instance
        {
            get
            {
                if (_Instance == null)
                {
                    _Instance = new SingletonFirst();
                    Console.WriteLine(nameof(SingletonFirst) + "实例化了");
                }
                return _Instance;
            }
        }
    }
}
