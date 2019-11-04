using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Core;

namespace VisitorPattern
{
    public class Student
    {
        public Student(string name)
        {
            this.Name = name;
            this.Sex = CoreService.Ran.Next(0, 10) % 2 == 0 ? "女" : "男";
        }

        public string Name { get; set; }

        public string Sex { get; set; }
    }
}
