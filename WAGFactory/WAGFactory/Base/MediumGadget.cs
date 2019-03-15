﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WAGFactory
{
    public class MediumGadget : AbstractGadget
    {
        public MediumGadget()
        {
        }

        public MediumGadget(ISize size) : base(size)
        {
        }

        public MediumGadget(ISize size, FinishColor color) : base(size, color)
        {
        }



        public override decimal Price => base.Price;

        public override void Paint(FinishColor color)
        {
            base.Paint(color);
        }
    }
}
