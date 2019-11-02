using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommandPattern
{
    /// <summary>
    /// 中间者：介于发送命令和执行命令中间（连长）
    /// </summary>
    public class Invoker
    {
        public Invoker(Command command)
        {
            Console.WriteLine("初始化一个中间者，将命令交给中间者");
            this.Command = command;
        }

        /// <summary>
        /// 中间者都会传递一个命令
        /// </summary>
        public Command Command { get; set; }

        /// <summary>
        /// 中间者执行发送命令对象的命令
        /// </summary>
        public void ExecuteCommand()
        {
            Console.WriteLine("中间者执行命令");
            Command.ExecuteCommand();
        }
    }
}
