using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Core;

namespace StatePattern
{
    public abstract class State
    {
        /// <summary>
        /// 用户
        /// </summary>
        public Person Person { get; set; }

        /// <summary>
        /// 余额
        /// </summary>
        public decimal Money { get; set; }

        /// <summary>
        /// 利率
        /// </summary>
        public decimal Rate { get; set; }

        /// <summary>
        /// 下限
        /// </summary>
        public decimal Min { get; set; }

        /// <summary>
        /// 上限
        /// </summary>
        public decimal Max { get; set; }

        /// <summary>
        /// 存钱
        /// </summary>
        /// <param name="money"></param>
        public abstract void SaveMoney(decimal money);

        /// <summary>
        /// 取钱
        /// </summary>
        /// <param name="money"></param>
        public abstract void GetMoney(decimal money);

        /// <summary>
        /// 查看获得的利息
        /// </summary>
        public abstract void ShowInterest();

        public abstract void ValidateStateChange();

        public void Show()
        {
            Console.WriteLine("当前余额：{0}", CoreService.MoneyFormat(this.Money));
            Console.WriteLine("当前利率：{0}", this.Rate);
            Console.WriteLine("当前状态：{0}", this.GetType().Name);
        }
    }
}
