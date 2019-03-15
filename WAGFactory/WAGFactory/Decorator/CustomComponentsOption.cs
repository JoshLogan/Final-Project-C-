using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WAGFactory;
namespace Decorator
{
    public class CustomComponentsOption : AbstractWagOption
    {
        public override decimal Price
        {
            get
            {
                return decoratedWag.Price + 65.00m;
            }
        }



        public CustomComponentsOption(IWag wag) : base(wag)
        {

        }

    }
}
