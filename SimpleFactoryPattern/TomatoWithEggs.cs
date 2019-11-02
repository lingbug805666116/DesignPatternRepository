using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleFactoryPattern
{
    public class TomatoWithEggs:Food
    {
        public override void Make()
        {
            Console.WriteLine("西红柿炒蛋做好了！");
        }
    }
}
