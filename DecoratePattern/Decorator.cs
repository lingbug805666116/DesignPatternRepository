using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecoratePattern
{
    /// <summary>
    /// 装饰类：也就是装饰者
    /// </summary>
    public class Decorator : Person
    {
        private Person _Person;

        //需要传入参数：我需要装饰谁
        public Decorator(Person person)
        {
            this._Person = person;
        }

        public override void Develop()
        {
            _Person.Develop();
        }
    }
}
