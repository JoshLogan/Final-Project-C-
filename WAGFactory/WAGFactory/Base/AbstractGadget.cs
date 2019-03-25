using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WAGFactory
{
    public abstract class AbstractGadget : AbstractWag
    {
        public override decimal Price { get; } = 6000.00m;

        public AbstractGadget(FinishColor color) : base(color)
        {
        }



        public AbstractGadget()
        {
        }
    }
}
