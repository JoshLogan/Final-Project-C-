using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WAGFactory
{
    public class LargeWidget : AbstractWidget
    {
        private string _gearParts = " 9 Gears,";
        private string _springParts = " 4 Springs.";
        private string _leverParts = " 2 Levers,";

        private FinishColor _color;

        public FinishColor Color
        {
            get
            {
                return _color;
            }
        }

        public override decimal Price { get; } = 20000.00m;

        public LargeWidget(FinishColor color) : base(color)
        {

        }

        public LargeWidget(FinishColor color, ISelectSize size) : base(color, size)
        {

        }

        public LargeWidget()
        {
        }

        public override string ToString()
        {
            return this.GetType().Name + ": Widget with " + _gearParts + _leverParts + _springParts + " With a finish that is " + _color + " and priced at $" + Price;
        }
    }
}
