using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MediatorPattern
{
    /// <summary>
    /// 中介：支付宝转账
    /// </summary>
    public class Alipay : Mediator
    {
        public Alipay(Person p1, Person p2) : base(p1, p2)
        {

        }

        public override void TransferTo1(decimal money)
        {
            Console.WriteLine("{0}给{1}转账{2}", _Person2.Name, _Person1.Name, money);
            _Person1.Money += money;
            _Person2.Money -= money;
        }

        public override void TransferTo2(decimal money)
        {
            Console.WriteLine("{0}给{1}转账{2}", _Person1.Name, _Person2.Name, money);
            _Person1.Money -= money;
            _Person2.Money += money;
        }
    }
}
