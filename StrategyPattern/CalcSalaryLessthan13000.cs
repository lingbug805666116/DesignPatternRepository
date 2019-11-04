using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Core;

namespace StrategyPattern
{
    /// <summary>
    /// 13000以下的计算策略
    /// </summary>
    public class CalcSalaryLessthan13000 : ICalcSalaryAfterTaxStrategy
    {
        public decimal CalcSalary(decimal money)
        {
            return CoreService.MoneyFormat(money - (8000 - 5000) * Convert.ToDecimal(0.1) - (money - 8000) * Convert.ToDecimal(0.2));
        }
    }
}
