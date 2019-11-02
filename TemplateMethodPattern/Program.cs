using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TemplateMethodPattern
{
    class Program
    {
        /// <summary>
        /// 模板方法模式：
        /// 日常生活中我们有很多东西都有规定好的模板，我们只需要在模板的基础上修改下就可以变成我们自己所需要的的东西
        /// 比如简历，我们在网上下载个简历模板，然后将自己的信息修改上去，这个就是我们自己的简历了
        ///
        /// 模板方法也是如此：
        /// 定义好一个模板骨架（下载简历模板），然后将一些具体的步骤延迟到子类中去实现（修改简历信息）
        ///
        /// 模板方法的模板骨架：
        /// 1.可以是抽象类：提供抽象方法，具体子类去实现（简历模板中是空白，你自己去填）
        /// 2.可以是虚方法：提供默认实现，子类可以去修改，也可以不修改（简历模板中已经填写了内容，根据需要是否修改）
        ///
        /// 此文中的例子：
        /// 我们炒菜时大部分步骤都是相同的，但是有些细节，不同的菜的做法有点不一样，此时就可以使用模板方法模式
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            //第一种实现：抽象类（不提供默认实现）
            //TestAbstract();

            //第二种实现：虚方法（提供默认实现）
            TestVirtual();

            Console.WriteLine("End");
            Console.ReadKey();
        }

        private static void TestAbstract()
        {
            MakeFood makePatato = new MakePatato();
            makePatato.Make();
            MakeFood makeChicken = new MakeChicken();
            makeChicken.Make();
        }

        private static void TestVirtual()
        {
            MakeFoodNew makePatato = new MakePatatoNew();
            makePatato.Make();
            MakeFoodNew makeChicken = new MakeChickenNew();
            makeChicken.Make();
        }
    }
}
