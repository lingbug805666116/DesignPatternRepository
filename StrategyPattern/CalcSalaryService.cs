using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Core;
using Console = System.Console;

namespace StrategyPattern
{
    public class CalcSalaryService
    {
        private ICalcSalaryAfterTaxStrategy _CalcSalaryStrategy;

        public CalcSalaryService(ICalcSalaryAfterTaxStrategy calcSalaryStrategy)
        {
            this._CalcSalaryStrategy = calcSalaryStrategy;
        }

        public void CalcSalaryAfterTax(decimal money)
        {
            var newMoney = _CalcSalaryStrategy.CalcSalary(money);
            Console.WriteLine("税前工资：{0}，税后工资：{1}，缴纳税：{2}", money, newMoney, CoreService.MoneyFormat(money - newMoney));
        }
    }
}
