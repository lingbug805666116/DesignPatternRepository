using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MediatorPattern
{
    public class Lisi : Person
    {
        public Lisi(string name, decimal money) : base(name, money)
        {

        }

        public override void TranferMoney(decimal money, Mediator mediator)
        {
            mediator.TransferTo2(money);
        }
    }
}
