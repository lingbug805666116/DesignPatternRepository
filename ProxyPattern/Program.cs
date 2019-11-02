using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProxyPattern
{
    class Program
    {
        /// <summary>
        /// 代理模式：
        /// 我们想要访问某个资源，但是我们由于种种原因访问不到，需要找一个中间人来帮忙我们访问，这就是代理模式的精髓所在
        /// 代理需要注意一点：我们只能真实对象去扩展，比如AOP操作，但是无法去覆盖点真实对象的实现（无法改变真实购买者的意图）
        /// 
        /// 日常生活的代理模式的例子：黄牛，代购，各种外卖配送员，产品经销商都是代理...代理无处不在
        /// 
        /// 代理模式按照使用目的可以分为以下几种：
        /// 1.远程（Remote）代理：为一个位于不同的地址空间的对象提供一个局域代表对象，这个不同的地址空间可以是本电脑中，也可以在另一台电脑中。最典型的例子就是：客户端调用后端系统的webservice，wcf，webapi等等
        /// 2.虚拟（Virtual）代理：根据需要创建一个资源消耗较大的对象，使得对象只在需要时才会被真正创建。
        /// 3.Copy-on-Write代理：虚拟代理的一种，把复制（或者叫克隆）拖延到只有在客户端需要时，才真正采取行动。
        /// 4.保护（Protect or Access）代理：控制一个对象的访问，可以给不同的用户提供不同级别的使用权限。
        /// 5.防火墙（Firewall）代理：保护目标不让恶意用户接近。
        /// 6.智能引用（Smart Reference）代理：当一个对象被引用时，提供一些额外的操作，比如将对此对象调用的次数记录下来等。
        /// 7.Cache代理：为某一个目标操作的结果提供临时的存储空间，以便多个客户端可以这些结果。
        /// 
        /// 上面的4,5,6,7其实有些小伙伴就看得出来，特别是第6条，暗示已经很明显了，这不就是AOP嘛，对的，没错
        /// 在上面所有种类的代理模式中，虚拟代理、远程代理、智能引用代理和保护代理较为常见的代理模式。
        /// 
        /// 此文中的例子：
        /// 我就举个代购的例子吧，太多了，随时随地都是在代理
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            //通过代理去购买
            Person proxy = new ProxyPerson();
            proxy.Buy();

            Console.WriteLine("End");
            Console.ReadKey();
        }
    }
}
