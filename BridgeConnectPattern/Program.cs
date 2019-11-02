using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeConnectPattern
{
    class Program
    {
        /// <summary>
        /// 桥接模式：
        /// GOF：将抽象部分和实现部分分离，使他们可以独立的变化，他们之间的关系只依赖于抽象
        /// 1.个人理解跟建造者模式差不多，也是类似于指挥者和建造者（如遥控器去遥控电视：换台，调音量；但是有不同牌子的遥控器和不同牌子的电视）
        /// 2.个人理解建造者模式和桥接模式的区别是：
        /// 建造者模式是一对多：一个指挥者，多个建造者（一个老板，多个员工：老板是实体，员工是抽象）
        /// 桥接模式是多对多：多个指挥者，多个建造者（多个老板，多个员工：老板是抽象，员工也是抽象），然后依赖抽象
        /// 基本上只要是多对多的，基本上都可以想到桥接模式。
        /// 最直接的桥接模式的例子：程序操作数据库的增删改查：
        /// 程序有java，.Net，Python等等...，数据库也有sqlserver，oracle，mysql，sqllite等等...
        /// 此文中的例子：
        /// 电脑装系统：电脑有联想，华硕，惠普等等...系统有win7，win8，win10等等...
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            //初始化电脑对象：可以有多个
            Computer computer1 = new AsusComputer();
            //指定操作系统：也可以是多个，这样就实现了多对多
            computer1.OsOperater = new Win10();
            computer1.DiskPartition();
            computer1.InstallOs();

            Computer computer2 = new LenovoComputer();
            computer2.OsOperater = new Win7();
            computer2.DiskPartition();
            computer2.InstallOs();

            Computer computer3 = new LenovoComputer();
            computer3.OsOperater = new Win10();
            computer3.DiskPartition();
            computer3.InstallOs();

            Console.WriteLine("End");
            Console.ReadKey();
        }
    }
}
