using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WAGFactory
{
    class SmallGadget : AbstractGadget
    {

        public SmallGadget()
        {

        }

        public SmallGadget(ISize size) : base(size)
        {
        }

        public SmallGadget(ISize size, FinishColor color) : base(size, color)
        {
        }



        public override decimal Price => base.Price;

        public override void Paint(FinishColor color)
        {
            base.Paint(color);
        }
    }
}
