using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WAGFactory;

namespace Builder
{
    class GadgetDirector : WagDirector
    {
        public override IWag Build(WagBuilder wagBuilder)
        {
            wagBuilder.BuildGadgetParts();

            return wagBuilder.Gadget;
        }
    }


}
