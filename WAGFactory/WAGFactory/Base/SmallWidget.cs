using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Singleton;

namespace WAGFactory
{
    public class SmallWidget : AbstractWidget
    {
        private string _gearParts = " 2 Gears,";
        private string _springParts = " 3 Springs";
        private string _leverParts = " 1 Lever,";
        public string serial { get; private set; }


        private FinishColor _color = FinishColor.PlainWhite;


        public FinishColor Color
        {
            get
            {
                return _color;
            }
        }


        public override decimal Price { get; } = 250.00m;



        public SmallWidget(FinishColor color) : base(color)
        {
            this._color = color;
            serial = WAGSerialGen.Instance.NextSerial(WaGs.smallwidget);
        }

        public SmallWidget()
        {
            serial = WAGSerialGen.Instance.NextSerial(WaGs.smallwidget);
        }



        public override string ToString()
        {
            Console.WriteLine("The Small Widget contains " + _gearParts + _leverParts + _springParts + ".");
            Console.WriteLine(" ");
            Console.WriteLine("With a finish that is " + _color + ".");
            Console.WriteLine(" ");
            Console.WriteLine("Priced at $" + Price + ".");
            Console.WriteLine(" ");
            return " Serial Number:  " + serial;
        }

    }
}
