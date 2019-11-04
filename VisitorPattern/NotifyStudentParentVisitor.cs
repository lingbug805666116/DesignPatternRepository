using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Core;

namespace VisitorPattern
{
    /// <summary>
    /// 访问者：通知学生父母的访问者
    /// </summary>
    public class NotifyStudentParentVisitor : IVisit
    {
        public void Visit(Teacher teacher)
        {
            teacher.Students.ForEach(r => Console.WriteLine("{0}通知{1}{2}记得晚上抽空检查{1}{3}。", teacher.Name, r.Name,
                CoreService.Ran.Next(10) % 2 == 0 ? "爸爸" : "妈妈", teacher.Homework));
        }
    }
}
