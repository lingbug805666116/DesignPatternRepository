using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TemplateMethodPattern
{
    /// <summary>
    /// 第二种实现：虚方法（提供默认实现）
    /// </summary>
    public class MakeFoodNew
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
        public virtual void PourFood()
        {
            Console.WriteLine("炒菜第三步：将菜倒入锅中");
        }

        public void StartPot()
        {
            Console.WriteLine("最后一步：等菜热了，起锅");
        }
    }
}
