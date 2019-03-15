using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WAGFactory;

namespace Builder
{
    public class GadgetBuilder : WagBuilder
    {
        private AbstractGadget _abstractGadgetInProgress;

        public override IWag Widget => throw new NotImplementedException();

        public override IWag Gadget
        {
            get
            {
                return _abstractGadgetInProgress;
            }
        }
        public GadgetBuilder(AbstractGadget gadget)
        {
            this._abstractGadgetInProgress = gadget;
        }

        public override void BuildGadgetParts()
        {
            Console.WriteLine("Building Widgets for Gadget");
        }
    }
}
