using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IteratorPattern
{
    /// <summary>
    /// 数据容器接口
    /// </summary>
    public interface IDataContainer
    {
        /// <summary>
        /// 获取迭代器
        /// </summary>
        /// <returns></returns>
        ITerator GetIterator();
    }
}
