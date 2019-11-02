using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommandPattern
{
    /// <summary>
    /// 团长的命令
    /// </summary>
    public class RegimentalCommand : Command
    {
        public RegimentalCommand(Receiver receiver) : base(receiver)
        {

        }

        public override void ExecuteCommand()
        {
            //接收命令的人：执行命令
            Console.WriteLine("接收者执行命令");
            Receiver.ExecuteCommand();
        }
    }
}
