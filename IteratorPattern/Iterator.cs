using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IteratorPattern
{
    /// <summary>
    /// 迭代器接口
    /// </summary>
    public interface ITerator
    {
        bool MoveNext();

        object GetCurrent();

        void Next();

        void Reset();
    }
}
