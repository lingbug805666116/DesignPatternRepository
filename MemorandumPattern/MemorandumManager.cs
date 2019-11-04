using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MemorandumPattern
{
    /// <summary>
    /// 备忘录管理者：备份之后放在这里保管备忘录
    /// </summary>
    public class MemorandumManager
    {
        public MemorandumManager()
        {
            this.DictionaryMemorandum = new Dictionary<string, ContactMemorandum>();
        }

        public Dictionary<string, ContactMemorandum> DictionaryMemorandum { get; set; }
    }
}
