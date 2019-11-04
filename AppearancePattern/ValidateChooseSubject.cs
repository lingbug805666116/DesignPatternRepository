using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppearancePattern
{
    public class ValidateChooseSubject
    {
        public bool IsFull(string subjectName)
        {
            //模拟判断课程是否选满
            Console.WriteLine("判断{0}课程是否选满...", subjectName);
            var ran = new Random();
            var isFull = ran.Next(10) % 2 == 0;
            Console.WriteLine("{0}课程{1}选满", subjectName, isFull ? "已经" : "暂未");
            return isFull;
        }
    }
}
