using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TemplateMethodPattern
{
    /// <summary>
    /// 第一种实现：抽象类
    /// </summary>
    public abstract class MakeFood
    {
        public void Make()
        {
            PourOil();
            WaitOilHot();
            PourFood();
            StartPot();
        }

        public void PourOil()
        {
            Console.WriteLine("炒菜第一步：倒油");
        }

        public void WaitOilHot()
        {
            Console.WriteLine("炒菜第二步：等油热");
        }

        /// <summary>
        /// 具体往锅里倒哪个菜，交给子类，子类必须实现
        /// </summary>
        public abstract void PourFood();

        public void StartPot()
        {
            Console.WriteLine("最后一步：等菜热了，起锅");
        }
    }
}
