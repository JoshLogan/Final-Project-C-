using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AbstractWagFactory;

namespace WAGFactory
{
    public abstract class AbstractWidget : IWidget
    {
        private ISize _size;

        public abstract decimal Price { get; }

        public FinishColor ColorType { get; }

        public int NumberOf { get; }
        public abstract ISize GetSize { get; }

        public AbstractWidget(FinishColor finish, ISize size)
        {
            this._size = size;
        }
        public AbstractWidget(int numberOf) : this(numberOf, FinishColor.PlainBlack)
        {
            this.NumberOf = numberOf;
        }

        public AbstractWidget(int numberOf, FinishColor finish)
        {
            this.NumberOf = numberOf;
        }

        public override string ToString()
        {
            return NumberOf + " " + this.GetType().Name + " created!";
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
