using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Core;

namespace StatePattern
{
    /// <summary>
    /// 透支账户
    /// </summary>
    public class BadState : State
    {
        public BadState(State state)
        {
            this.Money = state.Money;
            this.Person = state.Person;
            this.Rate = Convert.ToDecimal(0.005);
            this.Min = Decimal.MinValue;
            this.Max = 0;
        }

        public override void SaveMoney(decimal money)
        {
            this.Money += money;
            ValidateStateChange();
        }

        public override void GetMoney(decimal money)
        {
            Console.WriteLine("您已透支{0}元，无法取钱", CoreService.MoneyFormat(this.Money));
        }

        public override void ShowInterest()
        {
            Console.WriteLine("您的账户已透支，您没有利息可以获得");
        }

        public override void ValidateStateChange()
        {
            if (this.Money >= this.Max)
            {
                this.Person.State = new NewState(this);
            }
        }
    }
}
