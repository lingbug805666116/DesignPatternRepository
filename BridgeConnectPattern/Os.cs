using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeConnectPattern
{
    public abstract class Os
    {
        /// <summary>
        /// 装系统
        /// </summary>
        public abstract void InstallOs(string computerName);

        /// <summary>
        /// 分区
        /// </summary>
        public abstract void DiskPartition(string computerName);
    }
}
