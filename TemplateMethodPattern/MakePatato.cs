using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TemplateMethodPattern
{
    /// <summary>
    /// 炒土豆
    /// </summary>
    public class MakePatato : MakeFood
    {
        public override void PourFood()
        {
            Console.WriteLine("将土豆倒入锅中");
        }
    }
}
