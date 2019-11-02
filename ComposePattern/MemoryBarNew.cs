using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComposePattern
{
    public class MemoryBarNew : ProductNew
    {
        public MemoryBarNew(string name) : base(name)
        {

        }

        public override void Work()
        {
            Console.WriteLine(this.Name + "更加安全的工作啦！");
        }
    }
}
