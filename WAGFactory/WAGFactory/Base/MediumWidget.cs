using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WAGFactory
{
    class MediumWidget : AbstractWidget
    {
        public MediumWidget()
        {
        }

        public MediumWidget(ISize size) : base(size)
        {
        }

        public MediumWidget(ISize size, FinishColor color) : base(size, color)
        {
        }

        public override ISize Size => throw new NotImplementedException();

        public override decimal Price => base.Price;

        public override void Paint(FinishColor color)
        {
            base.Paint(color);
        }

        public override string ToString()
        {
            return base.ToString();
        }
    }
}
