using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MemorandumPattern
{
    /// <summary>
    /// 联系人对象
    /// </summary>
    public class Contact
    {
        public Contact(string name, string tel)
        {
            this.Name = name;
            this.Telephone = tel;
        }

        public string Name { get; set; }

        public string Telephone { get; set; }
    }
}
