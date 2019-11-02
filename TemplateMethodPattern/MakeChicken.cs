using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TemplateMethodPattern
{
    public class MakeChicken : MakeFood
    {
        public override void PourFood()
        {
            Console.WriteLine("将鸡肉倒入锅中");
        }
    }
}
