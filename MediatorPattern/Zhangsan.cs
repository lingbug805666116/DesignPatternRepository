using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MediatorPattern
{
    public class Zhangsan : Person
    {
        public Zhangsan(string name, decimal money) : base(name, money)
        {

        }

        public override void TranferMoney(decimal money, Mediator mediator)
        {
            mediator.TransferTo1(money);
        }
    }
}
