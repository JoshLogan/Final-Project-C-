using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WAGFactory
{
    public class SmallGadget : AbstractGadget
    {
        private string _gadgetMadeOf = " 1 Small Widget, 1 Medium Widget, and 0 Large Widgets ";
        private string _gadgetParts = " a Switch and a couple Buttons. ";
        private string _powerSource = " powered by a Battery. ";
        private FinishColor _color = FinishColor.PaintedBlue;

        public FinishColor Color
        {
            get { return _color; }
        }

        public override decimal Price { get; } = 27050.00m;


        public SmallGadget(ISelectSize size) : this(FinishColor.PlainBlack, size)
        {

        }

        public SmallGadget(FinishColor color, ISelectSize size) : base(color, size)
        {

        }

        public SmallGadget(FinishColor color) : base(color)
        {
        }

        public SmallGadget()
        {
        }

        public override string ToString()
        {
            return this.GetType().Name + ": Has " + _gadgetMadeOf + "with" + _gadgetParts + " It is " + _powerSource + " with a finish that is " + _color + " and priced at $" + Price;
        }
    }
}
