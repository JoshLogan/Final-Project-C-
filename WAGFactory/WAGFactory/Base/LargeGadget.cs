using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WAGFactory
{
    class LargeGadget : AbstractGadget
    {
        public LargeGadget()
        {
        }

        public LargeGadget(ISize size) : base(size)
        {
        }

        public LargeGadget(ISize size, FinishColor color) : base(size, color)
        {
        }

        public override ISize Size => throw new NotImplementedException();

        public override decimal Price => base.Price;

        public override void Paint(FinishColor color)
        {
            base.Paint(color);
        }
    }
}
