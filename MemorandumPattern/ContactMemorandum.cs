using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MemorandumPattern
{
    /// <summary>
    /// 备忘录对象
    /// </summary>
    public class ContactMemorandum
    {
        public ContactMemorandum(string name, List<Contact> contactList)
        {
            this.Name = name;
            this.ContactList = contactList;
            this.OperateTime = DateTime.Now;
        }

        public List<Contact> ContactList { get; set; }

        public string Name { get; set; }

        public DateTime OperateTime { get; set; }
    }
}
