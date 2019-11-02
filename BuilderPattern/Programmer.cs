using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuilderPattern
{
    public abstract class Programmer
    {
        public abstract void Develop();

        public abstract void Test();

        public abstract void Commit();
    }
}
