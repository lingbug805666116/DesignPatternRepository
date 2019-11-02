using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactoryPattern
{
    public class ChongqingFactory : AbstractFactory
    {
        public override Xiaolongkan CreateXiaolongkan()
        {
            return new ChongqingXiaolongkan();
        }

        public override Yuanlaosi CreateYuanlaosi()
        {
            return new ChongqingYuanlaosi();
        }
    }
}
