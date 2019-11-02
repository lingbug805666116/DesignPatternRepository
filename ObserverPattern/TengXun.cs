using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObserverPattern
{
    /// <summary>
    /// 腾讯（被观察者）：腾讯下面也有很多业务（公众号，游戏等等...）
    /// </summary>
    public abstract class TengXun
    {
        public string Title { get; set; }

        public string Content { get; set; }

        /// <summary>
        /// 存储观察我的人（粉丝）
        /// </summary>
        private List<IObserver> ObserverList = new List<IObserver>();

        /// <summary>
        /// 新增观察者（比如有新粉丝关注了我）
        /// </summary>
        /// <param name="observer"></param>
        public void Add(IObserver observer)
        {
            Console.WriteLine(observer.Name + "成为了你的新粉丝");
            ObserverList.Add(observer);
        }

        /// <summary>
        /// 移除观察者（比如有人取关了我）
        /// </summary>
        /// <param name="observer"></param>
        public void Remove(IObserver observer)
        {
            Console.WriteLine(observer.Name + "取消关注了你");
            ObserverList.Remove(ObserverList.First(r => r.Name == observer.Name));
        }

        /// <summary>
        /// 发送消息（我这边发送消息，我会给所有的观察者（粉丝）推送我的消息）
        /// </summary>
        public void SendMessage(string title, string content)
        {
            this.Title = title;
            this.Content = content;
            ObserverList.ForEach(r => r.ReceiveMessage(this));
        }
    }
}
