using Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StatePattern
{
    /// <summary>
    /// 高级账户
    /// </summary>
    public class SuperState : State
    {
        public SuperState(State state)
        {
            this.Money = state.Money;
            this.Person = state.Person;
            this.Rate = Convert.ToDecimal(0.005);
            this.Min = 1000;
            this.Max = Decimal.MaxValue;
        }

        public override void SaveMoney(decimal money)
        {
            this.Money += money;
            ValidateStateChange();
        }

        public override void GetMoney(decimal money)
        {
            this.Money -= money;
            ValidateStateChange();
        }

        public override void ShowInterest()
        {
            Console.WriteLine("您是高级账户，当前可以获得的利息：{0}", CoreService.MoneyFormat(this.Money * this.Rate));
        }

        public override void ValidateStateChange()
        {
            if (this.Money <= this.Min)
            {
                this.Person.State = new NewState(this);
            }
        }
    }
}
