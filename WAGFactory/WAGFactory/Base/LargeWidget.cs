using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WAGFactory
{
    class LargeWidget : AbstractWidget
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


        public LargeWidget()
        {
        }

        public LargeWidget(FinishColor color)
        {
            _color = color;
        }

        public LargeWidget(ISize size) : base(size)
        {
        }

        public LargeWidget(ISize size, FinishColor color) : base(size, color)
        {
        }



        public new decimal Price = 8600.00m;

        public override void CleanWidget()
        {
            Console.WriteLine("Cleaning Large Widget . . . ");
        }

        public override void InstallWidget()
        {
            Console.WriteLine("Installing Large Widget . . .");
        }



        public override void PrepWidget()
        {
            base.PrepWidget();
        }

        public override void TestWidget()
        {
            base.TestWidget();
        }

        public override string ToString()
        {
            return this.GetType().Name + ": Widget with " + _gearParts + _leverParts + _springParts + " With a finish that is " + _color + " and priced at $" + Price;
        }
    }
}
