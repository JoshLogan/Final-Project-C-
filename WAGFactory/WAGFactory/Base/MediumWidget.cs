using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WAGFactory
{
    public class MediumWidget : AbstractWidget
    {
        private string _gearParts = " 4 Gears,";
        private string _springParts = " 5 Springs.";
        private string _leverParts = " 3 Lever,";

        private FinishColor _color;

        public FinishColor Color
        {
            get
            {
                return _color;
            }
        }

        public override decimal Price { get; } = 15000.00m;

        public MediumWidget(FinishColor color) : base(color)
        {

        }

        public MediumWidget(FinishColor color, ISize size) : base(color, size)
        {
        }

        public MediumWidget()
        {
        }

        public override void Paint(FinishColor color)
        {
            base.Paint(color);
        }

        public override string ToString()
        {
            return this.GetType().Name + ": Widget with " + _gearParts + _leverParts + _springParts + " With a finish that is " + _color + " and priced at $" + Price;
        }
    }
}
