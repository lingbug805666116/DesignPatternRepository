using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppearancePattern
{
    public class ChooseSubject
    {
        public void Choose(string subjectName)
        {
            Console.WriteLine("选课成功，您已选择{0}课程！", subjectName);
        }
    }
}
