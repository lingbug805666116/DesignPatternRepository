using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Core;

namespace PrototypePattern
{
    [Serializable]
    public abstract class User
    {
        public User()
        {
            //模拟耗时操作
            CoreService.CostTime(5);
            Console.WriteLine("User被无参构造了");
        }

        public User(string name, string account, int age, List<string> roles, DateTime birthday, ClassModel classInfo)
        {
            //模拟耗时操作
            CoreService.CostTime(5);
            this.Name = name;
            this.Account = new StringBuilder(account);
            this.Age = age;
            this.Roles = roles;
            this.Birthday = birthday;
            this.ClassInfo = classInfo;
            Console.WriteLine("User被构造了");
        }

        public string Name { get; set; }

        //string是特殊的引用类型，为了区分
        public StringBuilder Account { get; set; }

        public int Age { get; set; }

        public List<string> Roles { get; set; }

        public DateTime Birthday { get; set; }

        public ClassModel ClassInfo { get; set; }

        public abstract User Clone();

        public abstract User DeepClone();
    }
}
