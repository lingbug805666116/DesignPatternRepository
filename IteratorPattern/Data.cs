using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IteratorPattern
{
    /// <summary>
    /// 数据对象
    /// </summary>
    public class Data : IDataContainer
    {
        /// <summary>
        /// 数据实体
        /// </summary>
        private int[] _Data;

        public Data(int[] data)
        {
            this._Data = data;
        }

        /// <summary>
        /// 集合长度
        /// </summary>
        public int Length
        {
            get { return this._Data.Length; }
        }

        /// <summary>
        /// 根据索引获取值
        /// </summary>
        /// <param name="index"></param>
        /// <returns></returns>
        public int GetValue(int index)
        {
            return this._Data[index];
        }

        /// <summary>
        /// 获取迭代器
        /// </summary>
        /// <returns></returns>
        public ITerator GetIterator()
        {
            return new DataIterator(this);
        }
    }
}
