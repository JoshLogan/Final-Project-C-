using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WAGFactory;

namespace Decorator
{
    public abstract class AbstractWagOption : AbstractWag
    {
        protected internal IWag decoratedWag;

        public AbstractWagOption(IWag wag) : base(wag.Size, FinishColor.GoldPlated)
        {
            this.decoratedWag = wag;
        }
    }
}
