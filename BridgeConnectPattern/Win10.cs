﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeConnectPattern
{
    public class Win10 : Os
    {
        public override void InstallOs(string computerName)
        {
            Console.WriteLine(computerName + "重装Win10系统！");
        }

        public override void DiskPartition(string computerName)
        {
            Console.WriteLine(computerName + "重新分区Win10系统！");
        }
    }
}
