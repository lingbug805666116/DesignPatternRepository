using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommandPattern
{
    /// <summary>
    /// 接收/执行命令的对象
    /// </summary>
    public class Receiver
    {
        public void ExecuteCommand()
        {
            Console.WriteLine("执行命令：负重越野五公里！");
        }
    }
}
