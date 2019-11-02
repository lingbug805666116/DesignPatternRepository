using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlyweightPattern
{
    /// <summary>
    /// 车：内部状态
    /// </summary>
    public class Car
    {
        public Car(string color)
        {
            this.Color = color;
            Console.WriteLine("Car被实例化，color = " + color);
        }

        public string Color { get; set; }

        public void Drive(Driver driver)
        {
            Console.WriteLine("{0}在开{1}的车！", driver.Name, Color);
        }
    }
}
