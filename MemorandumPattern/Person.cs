using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;
using Core;

namespace MemorandumPattern
{
    /// <summary>
    /// 手机用户
    /// </summary>
    public class Person
    {
        public Person(List<Contact> contactList)
        {
            this.ContactList = contactList;
        }

        /// <summary>
        /// 联系人列表
        /// </summary>
        public List<Contact> ContactList { get; set; }

        /// <summary>
        /// 备份联系人
        /// </summary>
        public ContactMemorandum CreateMemorandum(string name)
        {
            //这里一定要使用深拷贝，否则会引用对象的传递，备份就无效
            return new ContactMemorandum(name, CoreService.CloneData(this.ContactList));
        }

        /// <summary>
        /// 恢复联系人
        /// </summary>
        public void RecoveryMemorandum(ContactMemorandum memorandum)
        {
            //这里一定要使用深拷贝，否则会引用对象的传递，备份就无效
            this.ContactList = CoreService.CloneData(memorandum.ContactList);
        }

        /// <summary>
        /// 展示联系人
        /// </summary>
        public void ShowContactList()
        {
            Console.WriteLine("\t当前我的联系人列表有{0}个联系人：", this.ContactList.Count);
            int index = 0;
            foreach (var contact in ContactList)
            {
                Console.WriteLine("\t{0}.姓名：{1}，联系方式：{2}", ++index, contact.Name, contact.Telephone);
            }
            Console.WriteLine("----------------------------------------------------------");
        }
    }
}
