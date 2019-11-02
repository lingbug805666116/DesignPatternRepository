using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IteratorPattern
{
    /// <summary>
    /// 迭代器
    /// </summary>
    public class DataIterator : ITerator
    {
        /// <summary>
        /// 数据实体
        /// </summary>
        private Data _Data;

        /// <summary>
        /// 当前索引值
        /// </summary>
        private int _Index;

        public DataIterator(Data data)
        {
            this._Data = data;
            this._Index = 0;
        }

        /// <summary>
        /// 是否可以继续向下迭代
        /// </summary>
        /// <returns></returns>
        public bool MoveNext()
        {
            return this._Index < this._Data.Length;
        }

        /// <summary>
        /// 获取当前值
        /// </summary>
        /// <returns></returns>
        public object GetCurrent()
        {
            return this._Data.GetValue(this._Index);
        }

        /// <summary>
        /// 下一个索引
        /// </summary>
        public void Next()
        {
            this._Index++;
        }

        /// <summary>
        /// 重置索引
        /// </summary>
        public void Reset()
        {
            this._Index = 0;
        }
    }
}
