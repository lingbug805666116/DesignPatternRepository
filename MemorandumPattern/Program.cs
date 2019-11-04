using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Configuration;
using System.Text;
using System.Threading.Tasks;

namespace MemorandumPattern
{
    class Program
    {
        /// <summary>
        /// 备忘录模式：
        /// 虽然说是23中设计模式中的最后一个，但也是非常简单的一个设计模式
        /// 顾名思义，就是将数据备份起来，万一我们误操作之后，以后可以恢复到指定的状态
        ///
        /// 有一点需要注意：
        /// 备忘录模式有两种恢复模式：1.单点恢复（恢复到上一次）；2.多点恢复（有客户端指定，可以恢复到任意一次，只要之前备份过）
        /// 
        /// 此文中的例子：
        /// 备份通讯录，恢复通讯录
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            //初始化联系人集合
            var contacts = "张三，李四，王五，赵柳，小李，小王，aaa，bbb，老板，同事"
                .Split(new string[] { "，" }, StringSplitOptions.RemoveEmptyEntries).Select(
                    (r, i) =>
                    {
                        string tel = string.Empty;
                        while (tel.Length < 11)
                        {
                            tel += (i + 1);
                        }
                        return new Contact(r, tel);
                    }).ToList();
            //初始化手机用户
            var person = new Person(contacts);
            //展示当前联系人信息
            Console.WriteLine("初始化手机联系人：");
            person.ShowContactList();
            //初始化备忘录对象
            var manager = new MemorandumManager();
            //备份
            Console.WriteLine("第一次备份");
            manager.DictionaryMemorandum.Add("第一次备份", person.CreateMemorandum("第一次备份"));
            //删除几个联系人
            foreach (var item in person.ContactList.FindAll(r => "张三，王五".Split(new string[] { "，" }, StringSplitOptions.RemoveEmptyEntries).Contains(r.Name)))
            {
                person.ContactList.Remove(item);
            }
            Console.WriteLine("删除两个人联系人：");
            person.ShowContactList();
            //修改几个联系人
            person.ContactList.First(r => r.Name == "小王").Name = "大王";
            person.ContactList.Add(new Contact("ccc", "123456789101"));
            //展示当前联系人
            Console.WriteLine("修改一个联系人，新增一个联系人：");
            person.ShowContactList();
            //第二次备份当前联系人
            Console.WriteLine("第二次备份");
            manager.DictionaryMemorandum.Add("第二次备份", person.CreateMemorandum("第二次备份"));
            //删除几个联系人
            foreach (var item in person.ContactList.FindAll(r => "aaa，bbb".Split(new string[] { "，" }, StringSplitOptions.RemoveEmptyEntries).Contains(r.Name)))
            {
                person.ContactList.Remove(item);
            }
            Console.WriteLine("删除两个人联系人：");
            person.ShowContactList();
            //修改几个联系人
            person.ContactList.First(r => r.Name == "ccc").Name = "zzz";
            Console.WriteLine("修改一个联系人：");
            person.ShowContactList();
            //恢复第一次的数据
            person.RecoveryMemorandum(manager.DictionaryMemorandum["第一次备份"]);
            //展示当前联系人
            Console.WriteLine("恢复第一次备份的数据：");
            person.ShowContactList();
            //恢复第二次的数据
            person.RecoveryMemorandum(manager.DictionaryMemorandum["第二次备份"]);
            //展示当前联系人
            Console.WriteLine("恢复第二次备份的数据：");
            person.ShowContactList();

            Console.ReadKey();
        }
    }
}
