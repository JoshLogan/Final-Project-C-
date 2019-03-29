using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Singleton;

namespace WAGFactory
{
    public class MediumWidget : AbstractWidget
    {
        private string _gearParts = "4 Gears,";
        private string _springParts = " 5 Springs.";
        private string _leverParts = " 3 Levers,";
        public string serial { get; private set; }

        private FinishColor _color = FinishColor.PlainBlack;

        public FinishColor Color
        {
            get
            {
                return _color;
            }
        }

        public override decimal Price { get; } = 300.00m;

        public MediumWidget(FinishColor color) : base(color)
        {
            this._color = color;
            serial = WAGSerialGen.Instance.NextSerial(WaGs.mediumwidget);
        }


        public MediumWidget()
        {
            serial = WAGSerialGen.Instance.NextSerial(WaGs.mediumwidget);
        }



        public override string ToString()
        {
            Console.WriteLine("The Medium Widget contains: ");
            Console.WriteLine("-----  " + _gearParts + _leverParts + _springParts);
            Console.WriteLine("-----  With a finish that is: ");
            Console.WriteLine("-----  " + _color + ".");
            Console.WriteLine("-----  Starting Price: $" + Price + ".");

            return "***** Serial Number:  " + serial + " *****";
        }
    }
}
