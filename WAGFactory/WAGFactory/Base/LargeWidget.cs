using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Singleton;

namespace WAGFactory
{
    public class LargeWidget : AbstractWidget
    {
        private string _gearParts = " 9 Gears,";
        private string _springParts = " 4 Springs.";
        private string _leverParts = " 2 Levers,";
        public string serial { get; private set; }

        private FinishColor _color = FinishColor.PlatedGold;

        public FinishColor Color
        {
            get
            {
                return _color;
            }
        }

        public override decimal Price { get; } = 350.00m;

        public LargeWidget(FinishColor color) : base(color)
        {
            this._color = color;
            serial = WAGSerialGen.Instance.NextSerial(WaGs.largewidget);
        }



        public LargeWidget()
        {
            serial = WAGSerialGen.Instance.NextSerial(WaGs.largewidget);
        }

        public override string ToString()
        {
            Console.WriteLine("The Large Widget contains " + _gearParts + _leverParts + _springParts + ".");
            Console.WriteLine("With a finish that is " + _color + ".");
            Console.WriteLine("Priced at $" + Price + ".");
            return " Serial Number:  " + serial;

        }
    }
}
