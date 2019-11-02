using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppearancePattern
{
    class Program
    {
        /// <summary>
        /// 外观模式：
        /// 算是23种设计模式里面非常简单的一个模式，可以理解为面向对象三大特征的封装
        /// 先说下大概含义：
        /// 客户端在做一个业务逻辑操作时，需要调用系统后台三个接口
        /// 例如：学生选课：1.调用接口判断课程人数满了没有；2.没满的话选课；3.发送通知选课结果（成功or失败）
        /// 此时客户端需要调用后台三个接口，并且一旦业务有任何的变化，客户端or后台都有可能要修改
        /// 优点：客户端可以自定义自己的业务逻辑，根据不同业务调用不同接口
        /// 缺点：导致客户端和后台系统的耦合性非常的高
        /// 
        /// 使用外观模式，相当于给后台系统做了一个门面：
        /// 将一种特定的业务逻辑操作在外观封装起来
        /// 客户端只需要调用外观的那一端接口
        /// 至于外观调用了后台的什么接口，那就在外观中定义
        /// 这样客户端和后台系统的耦合性就非常低了
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            //TestNormal();

            //上述所有的逻辑都在客户端，虽然实现了自定义，但是难以维护，耦合性也非常高

            TestAppearance();

            Console.WriteLine("End");
            Console.ReadKey();
        }

        private static void TestNormal()
        {
            //常规选课：
            var validateSubject = new ValidateChooseSubject();
            var chooseSubject = new ChooseSubject();
            var notify = new SubjectNotify();
            var subjectName = "轮滑";
            //判断是否选满
            var isFull = validateSubject.IsFull(subjectName);
            //没选满，选课
            if (!isFull)
            {
                chooseSubject.Choose(subjectName);
            }
            //选课完毕，发送通知
            notify.Notify(subjectName, !isFull);
        }

        private static void TestAppearance()
        {
            //外观模式，将后台系统封装在这里面，客户端要调用也是统一调用外观，不会直接请求后台系统
            var subjectAppearance = new SubjectAppearance();
            subjectAppearance.ChooseSubject("轮滑");
        }
    }
}
