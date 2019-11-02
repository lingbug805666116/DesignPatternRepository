using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethodPattern
{
    public class PatatoFactoryCreator : FactoryCreator
    {
        public override Food CreateFactory()
        {
            return new Patato();
        }
    }
}
