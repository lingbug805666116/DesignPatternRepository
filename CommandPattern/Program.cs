using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace CommandPattern
{
    class Program
    {
        /// <summary>
        /// 命令模式：
        /// 一般来说，我们会给指定对象发送命令，然后指定对象去执行命令，比如妈妈让你洗碗（妈妈给你发命令：洗碗）
        /// 这样会导致耦合性很高，很难扩展
        /// 
        /// 使用命令模式，可以降低耦合
        /// 我们需要给指定对象发送命令，不会直接去命令那个对象，而是会通过一个中间对象来把命令传递过去
        /// 这样就降低了耦合性，增加了系统的可扩展性
        ///
        /// 例如：
        /// 在部队里，团长下命令集合，不可能去给每一个士兵说集合，不现实
        /// 这时团长把一连，二连，三连连长都叫过来，说集合
        /// 接下来三个连长去将自己连的士兵集合起来就可以了（具体要说连下面有排，排下面有班，那也是命令，这里不细说）
        ///
        /// 所以，此时
        /// 团长是发送命令者
        /// 士兵是执行命令者
        /// 连长是传达命令者
        /// 这样团长和士兵之间基本是没有什么耦合的
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            //初始化执行命令者
            var receiver = new Receiver();
            //初始化团长命令：将命令执行者传递进去（该命令是命令谁的）
            var command = new RegimentalCommand(receiver);
            //初始化中间者：传递参数（将命令交给他）
            var invoker = new Invoker(command);
            //中间者去传递命令，然后命令接收者去执行命令
            invoker.ExecuteCommand();

            Console.WriteLine("End");
            Console.ReadKey();
        }
    }
}
