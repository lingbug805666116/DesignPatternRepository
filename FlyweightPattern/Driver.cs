using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlyweightPattern
{
    /// <summary>
    /// 司机：外部状态
    /// </summary>
    public class Driver
    {
        public Driver(string name)
        {
            this.Name = name;
        }

        public string Name { get; set; }
    }
}
