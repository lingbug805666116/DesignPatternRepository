using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComposePattern
{
    public interface IComplexProduct
    {
        void Add(ProductNew product);

        void Remove(ProductNew product);
    }
}
