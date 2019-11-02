using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Core;

namespace StatePattern
{
    /// <summary>
    /// 新开户
    /// </summary>
    public class NewState : State
    {
        public NewState(decimal money, Person person)
        {
            this.Money = money;
            this.Person = person;
            this.Rate = Convert.ToDecimal(0.002);
            this.Min = 0;
            this.Max = 1000;
        }

        public NewState(State state) : this(state.Money, state.Person)
        {

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
            Console.WriteLine("您是新开账户，当前可以获得的利息：{0}", CoreService.MoneyFormat(this.Money * this.Rate));
        }

        public override void ValidateStateChange()
        {
            if (this.Money <= this.Min)
            {
                this.Person.State = new BadState(this);
            }
            else if (this.Money > this.Max)
            {
                this.Person.State = new SuperState(this);
            }
        }
    }
}
