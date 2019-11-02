using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProxyPattern
{
    /// <summary>
    /// 代理模式必须代理类和真实类实现同样的接口
    /// </summary>
    public abstract class Person
    {
        public abstract void Buy();
    }
}
