using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WAGFactory
{
    class MediumWidget : AbstractWidget
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

        public MediumWidget()
        {
        }
        public MediumWidget(FinishColor color) : base(color)
        {
            _color = color;
        }

        public MediumWidget(ISize size) : base(size)
        {
        }

        public MediumWidget(ISize size, FinishColor color) : base(size, color)
        {
        }



        public new decimal Price = 6600.00m;

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
