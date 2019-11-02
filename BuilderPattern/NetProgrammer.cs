using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuilderPattern
{
    public class NetProgrammer : Programmer
    {
        public override void Develop()
        {
            Console.WriteLine("开发.Net项目");
        }

        public override void Test()
        {
            Console.WriteLine("开发完毕，测试.Net项目");
        }

        public override void Commit()
        {
            Console.WriteLine("开发测试完毕，交付.Net项目");
        }
    }
}
