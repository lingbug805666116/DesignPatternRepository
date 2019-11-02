using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdapterPattern
{
    //开飞机（新方法）我不会，所以我需要将这个适配到我会的（已有的方法）
    public interface IAirplane
    {
        void Fly();
    }
}
