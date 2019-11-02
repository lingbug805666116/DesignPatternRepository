using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObserverPattern
{
    class Program
    {
        /// <summary>
        /// 观察者模式：
        /// 生活中处处可见观察者模式，例如：
        /// 微博，如果我发送一篇微博，系统得把我发送的新微博推送给我的每一个粉丝
        /// 微信公众号，公众号发送一篇文章，系统会把这篇文章推送给所有关注该公众号的用户
        /// ......很多很多
        ///
        /// 像这样子的一对多的关系，我们都可以使用观察者模式去实现它
        /// 观察者模式分为：1.观察者；2.被观察者
        ///
        /// 在上面的例子中，观察者就是那些粉丝们（多个），被观察者就是微信公众号或者我本人（一个）
        /// 他们一直观察着，一旦被观察者发生变化（发送微博/文章），观察者会立马做出响应（推送微博/文章）
        ///
        /// 此文中我会用两种方式去实现观察者模式：
        /// 1.常规实现：基本所有开发语言都可以去实现观察者模式
        /// 2..Net方式实现：基于.Net里面的事件机制去实现观察者模式
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            //第一种方式
            TestCommon();

            //第二种方式：.Net事件
            //TestEvent();

            Console.WriteLine("End");
            Console.ReadKey();
        }

        private static void TestCommon()
        {
            //初始化被观察者（微信公众号）
            TengXun wechatArticle = new WeChatArticle();
            //初始化被观察者（和平精英）
            TengXun game = new PeaceElite();
            //给微信公众号添加粉丝（观察者）
            wechatArticle.Add(new WeChatArticleFans("微信公众号粉丝：张三"));
            wechatArticle.Add(new WeChatArticleFans("微信公众号粉丝：李四"));
            wechatArticle.Add(new WeChatArticleFans("微信公众号粉丝：王五"));
            wechatArticle.Add(new WeChatArticleFans("微信公众号粉丝：赵柳"));
            Console.WriteLine("----------------------------------------------------------");
            //给和平精英添加玩家（观察者）
            game.Add(new TengXunGamer("和平精英玩家：张无忌"));
            game.Add(new TengXunGamer("和平精英玩家：秋刀"));
            game.Add(new TengXunGamer("和平精英玩家：琅琊榜"));
            game.Add(new TengXunGamer("和平精英玩家：金箍棒"));
            game.Add(new TengXunGamer("和平精英玩家：紧箍咒"));
            Console.WriteLine("----------------------------------------------------------");
            //微信公众号发通知（发表新文章）
            wechatArticle.SendMessage("一篇新文章", "来学习设计模式至观察者模式吧");
            Console.WriteLine("----------------------------------------------------------");
            //和平精英发通知（新动态）
            game.SendMessage("和平精英更新啦", "新玩法：火力模式，精英们快来保卫和平吧！");
            Console.WriteLine("----------------------------------------------------------");
            //取消关注
            game.Remove(new TengXunGamer("和平精英玩家：张无忌"));
            Console.WriteLine("----------------------------------------------------------");
            //再发送新的通知，取消关注的人就收不到推送了
            game.SendMessage("（和平精英）您有一条新消息", "万圣节，大家放开嗨");
            Console.WriteLine("----------------------------------------------------------");
        }

        private static void TestEvent()
        {
            ////初始化被观察者（微信公众号）
            //TengXunEvent wechatArticle = new WeChatArticle();
            ////初始化被观察者（和平精英）
            //TengXunEvent game = new PeaceElite();
            ////给微信公众号添加粉丝（观察者）
            //wechatArticle.Add(new WeChatArticleFans("微信公众号粉丝：张三").ReceiveMessage);
            //wechatArticle.Add(new WeChatArticleFans("微信公众号粉丝：李四").ReceiveMessage);
            //wechatArticle.Add(new WeChatArticleFans("微信公众号粉丝：王五").ReceiveMessage);
            //wechatArticle.Add(new WeChatArticleFans("微信公众号粉丝：赵柳").ReceiveMessage);
            //Console.WriteLine("----------------------------------------------------------");
            ////给和平精英添加玩家（观察者）
            //game.Add(new TengXunGamer("和平精英玩家：张无忌").ReceiveMessage);
            //game.Add(new TengXunGamer("和平精英玩家：秋刀").ReceiveMessage);
            //game.Add(new TengXunGamer("和平精英玩家：琅琊榜").ReceiveMessage);
            //game.Add(new TengXunGamer("和平精英玩家：金箍棒").ReceiveMessage);
            //game.Add(new TengXunGamer("和平精英玩家：紧箍咒").ReceiveMessage);
            //Console.WriteLine("----------------------------------------------------------");
            ////微信公众号发通知（发表新文章）
            //wechatArticle.SendMessage("一篇新文章", "来学习设计模式至观察者模式吧");
            //Console.WriteLine("----------------------------------------------------------");
            ////和平精英发通知（新动态）
            //game.SendMessage("和平精英更新啦", "新玩法：火力模式，精英们快来保卫和平吧！");
            //Console.WriteLine("----------------------------------------------------------");
            ////取消关注
            //game.Remove(new TengXunGamer("和平精英玩家：张无忌").ReceiveMessage);
            //Console.WriteLine("----------------------------------------------------------");
            ////再发送新的通知，取消关注的人就收不到推送了
            //game.SendMessage("（和平精英）您有一条新消息", "万圣节，大家放开嗨");
            //Console.WriteLine("----------------------------------------------------------");
        }
    }
}
