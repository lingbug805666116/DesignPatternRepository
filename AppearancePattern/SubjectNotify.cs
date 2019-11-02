using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppearancePattern
{
    public class SubjectNotify
    {
        public void Notify(string subjectName, bool isSuccess)
        {
            Console.WriteLine("通知：您{0}课程的选课结果为：{1}", subjectName, isSuccess ? "成功" : "失败");
        }
    }
}
