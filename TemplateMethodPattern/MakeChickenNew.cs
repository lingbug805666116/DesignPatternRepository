using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TemplateMethodPattern
{
    public class MakeChickenNew : MakeFoodNew
    {
        public override void PourFood()
        {
            Console.WriteLine("重写父类方法：将鸡肉倒入锅中");
        }
    }
}
