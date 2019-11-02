using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObserverPattern
{
    /// <summary>
    /// 腾讯游戏玩家（观察者）：观察腾讯游戏
    /// </summary>
    public class TengXunGamer : IObserver
    {
        public TengXunGamer(string name)
        {
            this.Name = name;
        }

        public string Name { get; set; }

        public void ReceiveMessage(TengXun tengxun)
        {
            Console.WriteLine("{0}收到了和平精英推送的一条消息：标题：{1}，内容：{2}", this.Name, tengxun.Title, tengxun.Content);
        }
    }
}
