using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Singleton;

namespace WAGFactory
{
    public class LargeGadget : AbstractGadget
    {

        public string serial { get; private set; }
        private string _gadgetMadeOf = " 3 Small Widgets, 6 Medium Widgets, and 3 Large Widgets";
        private string _gadgetParts = " 2 Switchs, 4 Buttons, and 5 Lights";
        private string _powerSource = " Generator Powered";
        private FinishColor _color = FinishColor.PlatedPlatinum;

        public FinishColor Color
        {
            get { return _color; }
        }

        public override decimal Price { get; } = 3935.00m;



        public LargeGadget(FinishColor color) : base(color)
        {
            this._color = color;
            serial = WAGSerialGen.Instance.NextSerial(WaGs.largegadget);
        }

        public LargeGadget()
        {
            serial = WAGSerialGen.Instance.NextSerial(WaGs.largegadget);
        }

        public override string ToString()
        {
            Console.WriteLine("The Large Gadget contains:");
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
