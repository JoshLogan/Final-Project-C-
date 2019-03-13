using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WAGFactory
{
    public class SmallWidget : AbstractWidget
    {
        public SmallWidget(int numberOf) : base(numberOf)
        {
        }

        public SmallWidget(int numberOf, FinishColor finish) : base(numberOf, finish)
        {
            Console.WriteLine("The small widget has 2 gears");
            Console.WriteLine("The small widget has 3 springs");
            Console.WriteLine("The small widget has  1 lever");
            Console.WriteLine("The small widget has a finish of " + finish);
        }

        public override decimal Price { get; } = 540.00m;


        public override string ToString()
        {
            return NumberOf + " " + this.GetType().Name + " created!";
        }
    }
}
