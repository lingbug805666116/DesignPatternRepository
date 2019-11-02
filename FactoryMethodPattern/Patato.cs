using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethodPattern
{
    public class Patato : Food
    {
        public override void Make()
        {
            Console.WriteLine("土豆做好了！");
        }
    }
}
