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
            //this.State=
        }

        public State State { get; set; }

        /// <summary>
        /// 存钱
        /// </summary>
        /// <param name="money"></param>
        public void SaveMoney(decimal money)
        {

        }

        /// <summary>
        /// 取钱
        /// </summary>
        /// <param name="money"></param>
        public void GetMoney(decimal money)
        {

        }

        /// <summary>
        /// 查看获得的利息
        /// </summary>
        /// <param name="money"></param>
        public void ShowInterest(decimal money)
        {

        }
    }
}
