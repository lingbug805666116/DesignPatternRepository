using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommandPattern
{
    /// <summary>
    /// 命令对象
    /// </summary>
    public abstract class Command
    {
        public Command(Receiver receiver)
        {
            Console.WriteLine("实例化一个命令");
            this.Receiver = receiver;
        }

        /// <summary>
        /// 每个命令都需要一个执行命令的对象
        /// </summary>
        public Receiver Receiver { get; set; }

        public abstract void ExecuteCommand();
    }
}
