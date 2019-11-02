using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComposePattern
{
    class Program
    {
        /// <summary>
        /// 组合模式：
        /// 开发中会涉及到简单对象和复杂对象，但是我们又希望能够一致性的对待他们
        /// 比如：电脑的文件夹，每个文件夹下面有文件（简单对象），也有文件夹（复杂对象），
        /// 我们往往都要做判断然后对待他们，一般来说，我们会想到树结构tree
        /// 此时我们希望能够对待他们一致，就需要使用到组合模式了
        /// 
        /// 组合模式的特征：
        /// 1.简单对象和复杂对象，复杂对象由多个简单对象构成
        /// 2.容器特征：既是对象，也是容器
        ///
        /// 此文中的例子：
        /// 电脑是一个产品，电脑由CPU，硬盘，内存条，电源，电池等等...构成，这些零件也都是产品
        /// 电脑既是产品，也是容器
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            //Test1();

            //上述执行完，大家应该也看到了有点不足：
            //有的产品不能有子零件，但是还是会有添加零件和移除零件的方法，因为是从产品类继承过来的嘛
            //这样就导致了不安全，因为客户端觉得有这个方法那肯定就是可以使用的，结果不能使用
            //所以，一种更安全的方式就是：
            //将添加零件和移除零件的方法只有复杂产品我们才会加上，其他的都没有
            //有两种方式加：
            //1.在复杂产品类中多定义两个方法（添加和删除）
            //2.定义一个添加产品，删除产品接口，复杂产品需要实现这些接口（规范）

            Test2();

            Console.WriteLine("End");
            Console.ReadKey();
        }

        private static void Test1()
        {
            //简单零件工作
            Product cpu = new Cpu("I7处理器");
            cpu.Work();
            //简单零件添加
            cpu.Add(new MemoryBar("给CPU加内存"));
            cpu.Work();
            //简单零件移除
            cpu.Remove(new MemoryBar("给CPU减内存"));
            cpu.Work();

            Console.WriteLine("--------------------------------------------");

            //复杂零件工作
            Product computer = new Computer("华硕笔记本");
            computer.Add(new Cpu("I7处理器"));
            computer.Work();
            //给简单零件添加零件再工作
            computer.Add(new MemoryBar("金士顿16G内存条"));
            computer.Work();
            //给复杂零件移除零件再工作
            computer.Remove(new MemoryBar("金士顿16G内存条"));
            computer.Work();
        }

        private static void Test2()
        {
            //简单零件工作
            ProductNew cpu = new CpuNew("I7处理器");
            cpu.Work();

            ProductNew memoryBar = new MemoryBarNew("金士顿16G内存条");
            memoryBar.Work();

            Console.WriteLine("--------------------------------------------");

            //复杂零件工作
            ComputerNew computer = new ComputerNew("华硕笔记本");
            computer.Add(new CpuNew("I7处理器"));
            computer.Work();

            Console.WriteLine("--------------------------------------------");

            //给简单零件添加零件再工作
            computer.Add(new MemoryBarNew("金士顿16G内存条"));
            computer.Work();

            Console.WriteLine("--------------------------------------------");

            //给复杂零件移除零件再工作
            computer.Remove(new MemoryBarNew("金士顿16G内存条"));
            computer.Work();
        }
    }
}
