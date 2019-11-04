using Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StatePattern
{
    /// <summary>
    /// 用户
    /// </summary>
    public class Person
    {
        public Person()
        {
            this.State = new NewState(0, this);
        }

        public State State { get; set; }

        /// <summary>
        /// 存钱
        /// </summary>
        /// <param name="money"></param>
        public void SaveMoney(decimal money)
        {
            this.State.SaveMoney(money);
            Show();
        }

        /// <summary>
        /// 取钱
        /// </summary>
        /// <param name="money"></param>
        public void GetMoney(decimal money)
        {
            this.State.GetMoney(money);
            Show();
        }

        /// <summary>
        /// 查看获得的利息
        /// </summary>
        public void ShowInterest()
        {
            this.State.ShowInterest();
            Show();
        }

        public void Show()
        {
            Console.WriteLine("当前余额：{0}", CoreService.MoneyFormat(this.State.Money));
            Console.WriteLine("当前利率：{0}", this.State.Rate);
            Console.WriteLine("当前状态：{0}", this.State.GetType().Name);
        }
    }
}
