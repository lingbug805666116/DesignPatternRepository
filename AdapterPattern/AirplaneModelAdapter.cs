using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdapterPattern
{
    public class AirplaneModelAdapter : Airplane
    {
        //此时的readonly与java的final等效
        private readonly Car _Car = new Car();

        public override void Fly()
        {
            _Car.Drive();
        }
    }
}
