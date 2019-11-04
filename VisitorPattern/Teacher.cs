using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VisitorPattern
{
    /// <summary>
    /// 老师抽象类
    /// </summary>
    public abstract class Teacher
    {
        public Teacher(string name, List<Student> students)
        {
            this.Name = name;
            this.Students = students;
        }

        /// <summary>
        /// 老师名称
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// 每个老师都有自己的学生
        /// </summary>
        public List<Student> Students { get; set; }

        /// <summary>
        /// 每个老师可以接受访问者的访问
        /// </summary>
        /// <param name="visitor"></param>
        public abstract void Accept(IVisit visitor);

        /// <summary>
        /// 老师布置的家庭作业
        /// </summary>
        public string Homework { get; set; }

        /// <summary>
        /// 每个老师都可以布置作业
        /// </summary>
        /// <param name="homeworkContent"></param>
        public abstract void AssignHomeword(string homeworkContent);
    }
}
