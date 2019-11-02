using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObserverPattern
{
    /// <summary>
    /// 微信公众号的粉丝（观察者）：观察微信公众号
    /// </summary>
    public class WeChatArticleFans : IObserver
    {
        public WeChatArticleFans(string name)
        {
            this.Name = name;
        }

        public string Name { get; set; }

        public void ReceiveMessage(TengXun tengxun)
        {
            Console.WriteLine("{0}收到了微信公众号推送的一篇文章：标题：{1}，内容：{2}", this.Name, tengxun.Title, tengxun.Content);
        }
    }
}
