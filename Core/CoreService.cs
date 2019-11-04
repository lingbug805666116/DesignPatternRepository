using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace Core
{
    public class CoreService
    {
        public static void RunLock(object locker, Action action)
        {
            lock (locker)
            {
                action.Invoke();
            }
        }

        public static int GetThreadId()
        {
            return Thread.CurrentThread.ManagedThreadId;
        }

        public static void CostTime(int max)
        {
            for (int i = 1; i <= max; i++)
            {
                Console.WriteLine("耗时操作：" + i);
                Thread.Sleep(1000);
            }
        }

        public static decimal MoneyFormat(decimal money)
        {
            return Math.Round(money, 2);
        }

        public static readonly Random Ran = new Random();

        public static T CloneData<T>(T data)
        {
            var json = JsonConvert.SerializeObject(data);
            return JsonConvert.DeserializeObject<T>(json);
        }
    }
}
