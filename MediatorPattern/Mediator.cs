using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MediatorPattern
{
    /// <summary>
    /// 中介对象
    /// </summary>
    public abstract class Mediator
    {
        protected Person _Person1;

        protected Person _Person2;

        public Mediator(Person p1, Person p2)
        {
            this._Person1 = p1;
            this._Person2 = p2;
        }

        /// <summary>
        /// 2转账给1
        /// </summary>
        /// <param name="money"></param>
        public abstract void TransferTo1(decimal money);

        /// <summary>
        /// 1转账给2
        /// </summary>
        /// <param name="money"></param>
        public abstract void TransferTo2(decimal money);
    }
}
