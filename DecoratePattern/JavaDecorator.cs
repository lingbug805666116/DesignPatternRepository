using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecoratePattern
{
    /// <summary>
    /// 具体的装饰者：将Java装饰到我的身上
    /// </summary>
    public class JavaDecorator : Decorator
    {
        public JavaDecorator(Person person) : base(person)
        {

        }

        public override void Develop()
        {
            base.Develop();
            Console.WriteLine("我会开发Java程序！");//装饰
        }
    }
}
