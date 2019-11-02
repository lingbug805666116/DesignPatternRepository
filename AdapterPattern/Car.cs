using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdapterPattern
{
    //已经存在的方法：我会开车
    public class Car
    {
        public void Drive()
        {
            Console.WriteLine("开汽车！");
        }
    }
}
