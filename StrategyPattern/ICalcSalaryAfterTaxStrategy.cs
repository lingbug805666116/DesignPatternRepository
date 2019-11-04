using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyPattern
{
    /// <summary>
    /// 计算税后工资接口
    /// </summary>
    public interface ICalcSalaryAfterTaxStrategy
    {
        decimal CalcSalary(decimal money);
    }
}
