using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeConnectPattern
{
    public class Computer
    {
        public Os OsOperater { get; set; }

        //一定要用虚方法：因为有多个牌子的电脑（多对多），虚方法可以将实现延后到子类，父类只是用来桥接
        public virtual void InstallOs(string computerName = null)
        {
            OsOperater.InstallOs(computerName);
        }

        public virtual void DiskPartition(string computerName = null)
        {
            OsOperater.DiskPartition(computerName);
        }
    }
}
