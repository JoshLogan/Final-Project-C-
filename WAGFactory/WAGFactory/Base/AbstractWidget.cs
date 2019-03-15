using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WAGFactory
{
    public abstract class AbstractWidget : AbstractWag
    {

        public override decimal Price { get; } = 500.00m;

        public AbstractWidget(ISize size) : this(size, FinishColor.PlainWhite)
        {

        }

        public AbstractWidget(ISize size, FinishColor color) : base(size, color)
        {

        }

        protected AbstractWidget()
        {
        }
    }
}
