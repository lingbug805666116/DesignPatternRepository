using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyPattern
{
    class Program
    {
        /// <summary>
        /// 策略者模式：
        /// 这是个很简单的模式，也是大家很常用的一个模式
        /// 上一个状态者模式说的是，一个对象通过不同的状态来展示出不同的形态，不同的业务逻辑
        /// 策略者模式也是如此，不同的策略展示出不同的结果
        ///
        /// 例如：
        /// 在计算税后工资时，我们需要根据税前工资计算出我们需要缴纳的税，减去这个税，才是我们的税后工资
        /// 但是不同的工资所需要的缴纳的税是不一样的，算法也是不一样的
        /// 比如现在5000以下不用缴税，5000到8000的部分是10%，8000到13000是20%等等
        /// 所以不同的工资计算的策略是不一样的
        ///
        /// 还有一个在开发中最常见的例子：
        /// 我们有很多数据库，如sqlserver，oracle，mysql，sqllite等等...
        /// 每个数据库都可以做增删改查，但是每个数据库如何去实现增删改查的策略是不一样的，这也是策略者模式
        ///
        /// 此文中的例子：计算税后工资
        /// 1.定义一个抽象类或者接口，在接口中定义一个行为：计算税后工资
        /// 2.分几个不同的类去实现这个接口，不同的类当然算法策略是不同的
        /// 3.然后客户端调用时，传递不同的策略，计算出不同的结果
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            var calcService1 = new CalcSalaryService(new CalcSalaryLessthan5000());
            calcService1.CalcSalaryAfterTax(4800);
            Console.WriteLine("-----------------------------------------------------");
            var calcService2 = new CalcSalaryService(new CalcSalaryLessthan8000());
            calcService2.CalcSalaryAfterTax(7750);
            Console.WriteLine("-----------------------------------------------------");
            var calcService3 = new CalcSalaryService(new CalcSalaryLessthan13000());
            calcService3.CalcSalaryAfterTax(12500);
            Console.WriteLine("-----------------------------------------------------");
            Console.ReadKey();
        }
    }
}
