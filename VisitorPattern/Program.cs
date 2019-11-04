using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VisitorPattern
{
    class Program
    {
        /// <summary>
        /// 访问者模式：
        /// 访问者模式解决的问题是：
        /// 将一个对象的数据结构保持不变，针对不同的业务，该对象可以接受不同访问者的调用，而展示出不同的形态，执行不同的业务
        /// 而访问者访问了这个对象之后，也可以反过来执行该对象的某些操作
        /// 这样将数据和业务分离开，降低了耦合性，也增强了系统的扩展性
        ///
        /// 访问者模式更多的运用于数据结构相对稳定的系统
        /// 
        /// 如果需要修改数据结构（如增添字段），那就必须要修改对象了
        /// 但是如果只是修改业务操作，那么我们可以不用修改对象，而编写一个新的访问者去访问这个对象，即可完成我们新的业务逻辑操作
        ///
        /// 此文中的例子：
        /// 学校每天放学的时候会给学生布置作业，学生回家完成，这是一个固定的业务，老师给学生布置作业
        /// 突然有一天，今天老师给学生布置的作业是回家背书，但是背会了之后，希望可以背诵给家长听，然后家长签字
        /// 此时我就需要在给学生布置完作业之后，也需要给每个学生的家长发送一条通知，告诉他们晚上回家抽空检查孩子背书
        ///
        /// 按照正常的业务逻辑，我们需要修改老师布置作业的业务逻辑，
        /// 但是使用访问者模式，我们只需要新添加一个访问者，去访问这个业务，然后将自己的新业务加进去就可以啦
        ///
        /// ok，let's coding
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            //初始化学生集合
            string studentNames = "张三，李四，王武，赵柳，小明，小红，小李，小王";
            List<Student> students = studentNames.Split(new string[] { "，" }, StringSplitOptions.RemoveEmptyEntries)
                .Select(r => new Student(r)).ToList();
            //初始化老师对象
            Teacher chineseTeacher = new ChineseTeacher("语文老师", students);
            //老师给学生布置作业
            chineseTeacher.AssignHomeword("练字");
            Console.WriteLine("----------------------------------------------------");
            //现在老师给学生布置一个新的作业：回家背书，还需要告诉学生的家长：晚上抽空检查孩子背书
            chineseTeacher.AssignHomeword("背诵古诗《静夜诗》");

            Console.WriteLine("----------------------------------------------------");
            //需要通知学生家长，此时就需要使用访问者模式了

            //初始化访问者
            IVisit visitor = new NotifyStudentParentVisitor();
            //通知家长
            visitor.Visit(chineseTeacher);

            Console.ReadKey();
        }
    }
}
