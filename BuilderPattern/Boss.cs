using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuilderPattern
{
    public class Boss
    {
        public void MakeProject(Programmer programmer)
        {
            programmer.Develop();
            programmer.Test();
            programmer.Commit();
        }
    }
}
