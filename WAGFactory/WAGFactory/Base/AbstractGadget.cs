using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WAGFactory
{
    public abstract class AbstractGadget : AbstractWag
    {

        public AbstractGadget(ISize size) : this(size, FinishColor.PlainBlack)
        {

        }

        public AbstractGadget(ISize size, FinishColor color) : base(size, color)
        {

        }

        protected AbstractGadget()
        {
        }

        public override decimal Price { get; } = 1900.00m;
    }
}
