﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdapterPattern
{
    public class AirplaneClassAdapter : Car, IAirplane
    {
        public void Fly()
        {
            this.Drive();
        }
    }
}
