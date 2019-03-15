using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WAGFactory;

namespace Decorator
{
    public class EverythingGoldOption : AbstractWagOption
    {
        public override decimal Price
        {
            get
            {
                return decoratedWag.Price + 2100.00m;
            }
        }

        public override ISize Size => throw new NotImplementedException();

        public EverythingGoldOption(IWag wag) : base(wag)
        {

        }

    }
}
