using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactoryPattern
{
    public class ShanghaiFactory : AbstractFactory
    {
        public override Xiaolongkan CreateXiaolongkan()
        {
            return new ShanghaiXiaolongkan();
        }

        public override Yuanlaosi CreateYuanlaosi()
        {
            return new ShanghaiYuanlaosi();
        }
    }
}
