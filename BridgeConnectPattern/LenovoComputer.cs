using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeConnectPattern
{
    public class LenovoComputer : Computer
    {
        public override void InstallOs(string computerName = null)
        {
            base.InstallOs("联想");
        }

        public override void DiskPartition(string computerName = null)
        {
            base.DiskPartition("联想");
        }
    }
}
