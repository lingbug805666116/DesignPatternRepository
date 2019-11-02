using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObserverPattern
{
    /// <summary>
    /// 观察者接口
    /// </summary>
    public interface IObserver
    {
        string Name { get; set; }

        /// <summary>
        /// 观察者接收消息
        /// </summary>
        /// <param name="tengxun"></param>
        void ReceiveMessage(TengXun tengxun);
    }
}
