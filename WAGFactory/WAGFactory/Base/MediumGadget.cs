using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WAGFactory
{
    public class MediumGadget : AbstractGadget
    {
        private string _gadgetMadeOf = " 2 Small Widget, 2 Medium Widget, and 1 Large Widgets ";
        private string _gadgetParts = " 1 Switch, 2 Buttons, and 3 Lights. ";
        private string _powerSource = " solar powered. ";
        private FinishColor _color;

        public FinishColor Color
        {
            get { return _color; }
        }

        public override decimal Price { get; } = 110000.00m;

        public MediumGadget(ISelectSize size) : this(FinishColor.PlainBlack, size)
        {

        }

        public MediumGadget(FinishColor color, ISelectSize size) : base(color, size)
        {

        }

        public MediumGadget(FinishColor color) : base(color)
        {
        }

        public MediumGadget()
        {
        }

        public override string ToString()
        {
            return this.GetType().Name + ": Has " + _gadgetMadeOf + "with" + _gadgetParts + " It is " + _powerSource + " with a finish that is " + _color + " and priced at $" + Price;
        }
    }
}
