using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObserverPattern
{
    public abstract class TengXunEvent
    {
        public string Title { get; set; }

        public string Content { get; set; }

        /// <summary>
        /// 存储观察我的人（粉丝）
        /// </summary>
        private event NotifyEventHandler ObserverEvent;

        /// <summary>
        /// 新增观察者（比如有新粉丝关注了我）
        /// </summary>
        /// <param name="observerEventHandler"></param>
        public void Add(NotifyEventHandler observerEventHandler)
        {
            ObserverEvent += observerEventHandler;
        }

        /// <summary>
        /// 移除观察者（比如有人取关了我）
        /// </summary>
        /// <param name="observerEventHandler"></param>
        public void Remove(NotifyEventHandler observerEventHandler)
        {
            ObserverEvent -= observerEventHandler;
        }

        /// <summary>
        /// 发送消息（我这边发送消息，我会给所有的观察者（粉丝）推送我的消息）
        /// </summary>
        public void SendMessage(string title, string content)
        {
            this.Title = title;
            this.Content = content;
            ObserverEvent(this);
        }
    }

    public delegate void NotifyEventHandler(TengXunEvent tengxun);
}
