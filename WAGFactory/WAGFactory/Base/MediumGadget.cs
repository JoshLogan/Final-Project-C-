using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Singleton;

namespace WAGFactory
{
    public class MediumGadget : AbstractGadget
    {
        public string serial { get; private set; }

        private string _gadgetMadeOf = " 2 Small Widgets, 2 Medium Widgets, and 1 Large Widget";
        private string _gadgetParts = " 1 Switch, 2 Buttons, 3 Lights";
        private string _powerSource = " Solar Powered";
        private FinishColor _color = FinishColor.PaintedGreen;

        public FinishColor Color
        {
            get { return _color; }
        }

        public override decimal Price { get; } = 1373.00m;



        public MediumGadget(FinishColor color) : base(color)
        {
            this._color = color;
            serial = WAGSerialGen.Instance.NextSerial(WaGs.mediumgadget);
        }

        public MediumGadget()
        {
            serial = WAGSerialGen.Instance.NextSerial(WaGs.mediumgadget);
        }

        public override string ToString()
        {
            Console.WriteLine("The Medium Gadget contains:");
            Console.WriteLine("+++++ " + _gadgetMadeOf + ".");
            Console.WriteLine("----- This Gadget comes with:   -----");
            Console.WriteLine("+++++ " + _gadgetParts + ".");
            Console.WriteLine("----- Power Soruce:             -----");
            Console.WriteLine("+++++  " + _powerSource + ". ");
            Console.WriteLine("----- With a finish that is:    -----");
            Console.WriteLine("-----  " + _color + ".");
            Console.WriteLine("----- Priced at $" + Price + ".");
            return "***** Serial Number: " + serial + " *****";
        }
    }
}
