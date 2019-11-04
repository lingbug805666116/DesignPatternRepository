using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Core;

namespace StrategyPattern
{
    /// <summary>
    /// 8000以下的计算策略
    /// </summary>
    public class CalcSalaryLessthan8000 : ICalcSalaryAfterTaxStrategy
    {
        public decimal CalcSalary(decimal money)
        {
            //5000到8000的部分缴纳10%，然后工资减去税得到税后工资
            return CoreService.MoneyFormat(Convert.ToDecimal(money - ((money - 5000) * Convert.ToDecimal(0.1))));
        }
    }
}
