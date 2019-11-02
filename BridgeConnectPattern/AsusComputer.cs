using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeConnectPattern
{
    public class AsusComputer : Computer
    {
        public override void InstallOs(string computerName = null)
        {
            base.InstallOs("华硕");
        }

        public override void DiskPartition(string computerName = null)
        {
            base.DiskPartition("华硕");
        }
    }
}
