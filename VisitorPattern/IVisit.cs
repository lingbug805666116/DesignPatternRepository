using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VisitorPattern
{
    /// <summary>
    /// 访问者接口，用于访问老师
    /// </summary>
    public interface IVisit
    {
        void Visit(Teacher teacher);
    }
}
