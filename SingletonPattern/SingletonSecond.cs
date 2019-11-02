using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Core;

namespace SingletonPattern
{
    public sealed class SingletonSecond
    {
        private SingletonSecond() { }

        private static SingletonSecond _Instance = null;

        private static readonly object _Locker = new object();

        public static SingletonSecond Instance
        {
            get
            {
                //这样可以避免并发多次实例化，
                //但是会影响性能，每一次进来判断都是排队，性能缺失很大
                CoreService.RunLock(_Locker, () =>
                {
                    if (_Instance == null)
                    {
                        _Instance = new SingletonSecond();
                        Console.WriteLine(nameof(SingletonSecond) + "实例化了");
                    }
                });
                return _Instance;
            }
        }
    }
}
