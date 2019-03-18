using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WAGFactory
{
    public class LargeGadget : AbstractGadget
    {
        private string _gadgetMadeOf = " 3 Small Widget, 6 Medium Widget, and 3 Large Widgets ";
        private string _gadgetParts = " 2 Switchs, 4 Buttons, and 5 Lights. ";
        private string _powerSource = " Generator powered. ";
        private FinishColor _color;

        public FinishColor Color
        {
            get { return _color; }
        }

        public override decimal Price { get; } = 1100000.00m;

        public LargeGadget(ISize size) : this(FinishColor.PlainBlack, size)
        {

        }

        public LargeGadget(FinishColor color, ISize size) : base(color, size)
        {

        }

        public LargeGadget(FinishColor color) : base(color)
        {
        }

        public LargeGadget()
        {
        }

        public override string ToString()
        {
            return this.GetType().Name + ": Has " + _gadgetMadeOf + "with" + _gadgetParts + " It is " + _powerSource + " with a finish that is " + _color + " and priced at $" + Price;
        }
    }
}
