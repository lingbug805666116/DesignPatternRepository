using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VisitorPattern
{
    /// <summary>
    /// 语文老师
    /// </summary>
    public class ChineseTeacher : Teacher
    {
        public ChineseTeacher(string name, List<Student> students) : base(name, students)
        {

        }

        public override void Accept(IVisit visitor)
        {
            visitor.Visit(this);
        }

        public override void AssignHomeword(string homeworkContent)
        {
            this.Homework = homeworkContent;
            Console.WriteLine("{0}给他的学生布置的作业是：{1}，{0}有{2}个学生，分别叫：{3}", this.Name, homeworkContent, this.Students.Count,
                string.Join("，", this.Students.Select(r => string.Format("{0}（{1}）", r.Name, r.Sex))));
        }
    }
}
