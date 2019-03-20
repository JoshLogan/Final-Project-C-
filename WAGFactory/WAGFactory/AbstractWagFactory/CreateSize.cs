using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractWagFactory
{
    public class CreateSize : ICreateSize
    {
        public string SmallWidget { get { return "Creating Small Widget"; } }

        public string MediumWidget { get { return "Creating Medium Widget"; } }

        public string LargeWidget { get { return "Creating Large Widget"; } }

        public string SmallGadget { get { return "Creating Small Gadget"; } }

        public string MediumGadget { get { return "Creating Medium Gadget"; } }

        public string LargeGadget { get { return "Creating Large Gadget"; } }
    }
}
