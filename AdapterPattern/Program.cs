using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdapterPattern
{
    class Program
    {
        /// <summary>
        /// 适配器模式：
        /// 将已实现的方法适配到未实现的方法上
        /// 分为：1.类适配器；2.对象适配
        /// 例如：我会开汽车，但是我不会开飞机，但是现在客户要求会开飞机的，我可以使用适配器模式将开汽车适配到开飞机上（不恰当的比喻）
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            //TestAdapterClass();
            TestAdapterModel();
            Console.WriteLine("End");
            Console.ReadKey();
        }

        private static void TestAdapterClass()
        {
            //类适配器：
            //1.我会开车，不会开飞机，但是现在客户要求开飞机
            //2.定义开飞机的接口，客户要我开，也就是我必须要实现开飞机的接口
            //3.继承开车的类，同时实现开飞机的接口
            //4.在实现开飞机的方法中调用开车类中的开车的方法（将没有的转换到有的）
            var airplaneAdapter = new AirplaneClassAdapter();
            airplaneAdapter.Fly();
        }

        private static void TestAdapterModel()
        {
            //对象适配器：
            //1.我会开车，不会开飞机，但是现在客户要求开飞机
            //2.定义飞机对象，里面有一个开飞机的方法，不做任何实现（因为我不会开飞机），注意：一定要是虚方法（可以被子类重写）
            //3.定义飞机适配器对象，继承飞机类
            //4.在飞机适配器对象中重写父类的开飞机的方法：在适配器对象内部定义一个开车对象，然后开飞机方法调用开车对象的开车方法（将没有的转换到有的）
            var airplaneAdapter = new AirplaneModelAdapter();
            airplaneAdapter.Fly();
        }
    }
}
