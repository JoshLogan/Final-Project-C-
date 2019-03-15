using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WAGFactory
{
    public class SmallWidget : AbstractWidget
    {
        private string _gearParts = " 2 Gears,";
        private string _springParts = " 3 Springs.";
        private string _leverParts = " 1 Lever,";
        private FinishColor _color;

        public FinishColor Color
        {
            get
            {
                return _color;
            }
        }

        public SmallWidget()
        {
        }

        public SmallWidget(ISize size) : base(size)
        {
        }

        public SmallWidget(ISize size, FinishColor color) : base(size, color)
        {

        }

        public SmallWidget(FinishColor color)
        {
            _color = color;
        }

        public new decimal Price = 3500.00m;

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
