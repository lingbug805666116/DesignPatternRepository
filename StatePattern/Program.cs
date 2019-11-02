using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StatePattern
{
    class Program
    {
        /// <summary>
        /// 状态者模式：
        /// 一个对象有多种不同的状态来表现出不同的形态
        /// 如果不停的用if else去判断的话，会导致程序的耦合性很高，而且不利于维护
        /// 所以此时拥有了状态者模式
        ///
        /// 此文中的例子：
        /// 用户的银行账户：
        /// 分为三个状态：
        /// 1.新开户：账户金额为0-1000，利息为0.2%
        /// 2.高级账户：账户余额为10000以上，利息为0.5%
        /// 3.透支账户：账户余额为0以下，利息为0
        /// 
        /// 状态公共的操作有：存钱，取钱，查询可以获得的利息费用
        /// 用户的操作有：存钱，取钱，查询可以获得的利息费用
        /// 用户的属性有：当前余额，当前利率
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {

        }
    }
}
