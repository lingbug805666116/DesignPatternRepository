using Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SingletonPattern
{
    public sealed class SingletonThird
    {
        private SingletonThird() { }

        private static SingletonThird _Instance = null;

        private static readonly object _Locker = new object();

        public static SingletonThird Instance
        {
            get
            {
                //通过两次判断，即不会特别影响性能，还可以达到单例的效果
                //可以多线程进行判断操作，但是如果未实例化，再次进去实例化的时候，就要进行排队判断了
                if (_Instance == null)
                {
                    CoreService.RunLock(_Locker, () =>
                    {
                        if (_Instance == null)
                        {
                            _Instance = new SingletonThird();
                            Console.WriteLine(nameof(SingletonThird) + "实例化了");
                        }
                    });
                }
                return _Instance;
            }
        }
    }
}
