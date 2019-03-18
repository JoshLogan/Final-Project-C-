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


        public override decimal Price { get; } = 12500.00m;

        public SmallWidget(SmallSize size) : this(FinishColor.PlainWhite, size)
        {

        }

        public SmallWidget(FinishColor color, ISize size) : base(color, size)
        {

        }

        public SmallWidget(FinishColor color) : base(color)
        {
        }

        public SmallWidget()
        {
        }

        public override string ToString()
        {
            return this.GetType().Name + ": Widget has " + _gearParts + _leverParts + _springParts + " with a finish that is " + _color + " and priced at $" + Price;
        }

    }
}
