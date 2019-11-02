using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MediatorPattern
{
    class Program
    {
        /// <summary>
        /// 中介者模式：
        /// 生活中到处都是中介者模式
        /// 例如：
        /// 原来我们买东西，需要将现金给卖家，现在可以用支付宝，微信转账来操作，解决了没有零钱和算错账的问题
        /// 原来我们聊天，只能去找到要聊天的那个人，然后聊天，现在可以直接使用微信或者QQ来聊天
        /// ......等等
        ///
        /// 上述所说的支付宝啊，微信啊其实都是中介者
        ///
        /// 例如转账：
        /// 不用中介者模式：我给你钱，我的钱减少，你的钱增加，万一你或者我计算错了怎么办呢，万一人更多了怎么办呢，一错错一大片
        /// 使用中介者模式：我支付宝转给你钱，你的钱增加，我的钱减少，支付宝的计算能力肯定大于人（找个擅长算数的人去算），万一算错了，直接修改支付宝就可以了
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            //初始化用户
            Person zhangsan = new Zhangsan("张三", 100);
            Person lisi = new Lisi("李四", 50);
            zhangsan.ShowMoney();
            lisi.ShowMoney();
            //初始化中介者：帮忙转账算钱的人
            Mediator alipay = new Alipay(zhangsan, lisi);

            Console.WriteLine("-------------------------------------------");

            zhangsan.TranferMoney(15, alipay);
            zhangsan.ShowMoney();
            lisi.ShowMoney();

            Console.WriteLine("-------------------------------------------");

            lisi.TranferMoney(25, alipay);
            zhangsan.ShowMoney();
            lisi.ShowMoney();

            Console.WriteLine("-------------------------------------------");
            Console.WriteLine("End");
            Console.ReadKey();
        }
    }
}
