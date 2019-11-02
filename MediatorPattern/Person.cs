using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MediatorPattern
{
    /// <summary>
    /// 用户
    /// </summary>
    public abstract class Person
    {
        public Person(string name, decimal money)
        {
            this.Name = name;
            this.Money = money;
        }

        public string Name { get; set; }

        public decimal Money { get; set; }

        /// <summary>
        /// 用户转账，使用中介转
        /// </summary>
        /// <param name="money"></param>
        /// <param name="mediator"></param>
        public abstract void TranferMoney(decimal money, Mediator mediator);

        public void ShowMoney()
        {
            Console.WriteLine("{0}现在的钱是：{1}", this.Name, this.Money);
        }
    }
}
