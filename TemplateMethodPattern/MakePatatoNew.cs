using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TemplateMethodPattern
{
    public class MakePatatoNew : MakeFoodNew
    {
        //使用默认实现

        public override void PourFood()
        {
            Console.WriteLine("重写方法：将土豆倒入锅中");
        }
    }
}
