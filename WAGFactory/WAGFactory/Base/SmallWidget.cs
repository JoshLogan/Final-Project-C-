using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WAGFactory
{
    public class SmallWidget : AbstractWidget
    {
        public SmallWidget(int numberOf) : base(numberOf)
        {
        }

        public SmallWidget(ISize size, FinishColor finish) : base(size, finish)
        {
        }

        public override decimal Price { get; } = 540.00m;
    }
}
