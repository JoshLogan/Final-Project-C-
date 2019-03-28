using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Singleton;

namespace WAGFactory
{
    public class SmallGadget : AbstractGadget
    {
        public string serial { get; private set; }
        private string _gadgetMadeOf = " 1 Small Widget, 1 Medium Widget, and 0 Large Widgets ";
        private string _gadgetParts = " a Switch and a couple Buttons. ";
        private string _powerSource = " powered by a Battery. ";
        private FinishColor _color = FinishColor.PaintedRoyalBlue;

        public FinishColor Color
        {
            get { return _color; }
        }

        public override decimal Price { get; } = 630.00m;

        public override void Paint(FinishColor color)
        {
            this._color = Color;
        }

        public SmallGadget(FinishColor color) : base(color)
        {
            this._color = color;
            serial = WAGSerialGen.Instance.NextSerial(WaGs.smallgadget);
        }

        public SmallGadget()
        {
            serial = WAGSerialGen.Instance.NextSerial(WaGs.smallgadget);
        }

        public override string ToString()
        {
            Console.WriteLine(" * The Small Gadget contains: * ");
            Console.WriteLine(" * " +_gadgetMadeOf + ".      * ");
            Console.WriteLine("This Gadget comes with: ");
            Console.WriteLine(_gadgetParts + ".");
            Console.WriteLine("Power Soruce: ");
            Console.WriteLine(_powerSource + ".");
            Console.WriteLine("With a finish that is: ");
            Console.WriteLine(_color + ".");
            Console.WriteLine("Priced at $" + Price + ".");
            return "Serial Number: " + serial;
        }
    }
}
