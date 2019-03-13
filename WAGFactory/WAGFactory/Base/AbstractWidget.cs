using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AbstractWAGFactory;

namespace WAGFactory
{
    public abstract class AbstractWidget : IWidget
    {
        private ISize size;
        private FinishColor finish;
        private int _numberOf;
        private bool _isSmall;
        public abstract decimal Price { get; }

        public FinishColor ColorType { get { return finish; } }

        public int NumberOf
        {
            get
            {
                return _numberOf;
            }
        }
        public bool IsSmall
        {
            get
            {
                return _isSmall;
            }
        }
        public AbstractWidget(ISize size, FinishColor finish)
        {
            this.finish = finish;
            this.size = size;
        }
        public AbstractWidget(int numberOf)
        {
            this._numberOf = numberOf;

        }
        public override string ToString()
        {
            return this.GetType().Name + " with " + _numberOf + " gears.";
        }

        public void Paint(FinishColor finish)
        {
            Console.WriteLine("The finish of the widget is " + finish);
        }

        public void TestWidget()
        {
            Console.WriteLine("Testing the Widget . .  . ");
        }

        public void CleanWidget()
        {
            Console.WriteLine("Cleaning Widget . . . . ");
        }


    }
}
