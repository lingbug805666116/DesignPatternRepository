using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyPattern
{
    /// <summary>
    /// 5000以下的计算策略
    /// </summary>
    public class CalcSalaryLessthan5000 : ICalcSalaryAfterTaxStrategy
    {
        public decimal CalcSalary(decimal money)
        {
            //5000以下不用缴纳税
            return money;
        }
    }
}
