using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractWagFactory
{
    public class CreateSize : ICreateSize
    {
        public string SmallWidget { get { return "Creating Small Widgets"; } }

        public string MediumWidget { get { return "Creating Medium Widgets"; } }

        public string LargeWidget { get { return "Creating Large Widgets"; } }

        public string SmallGadget { get { return "Creating Small Gadgets"; } }

        public string MediumGadget { get { return "Creating Medium Gadgets"; } }

        public string LargeGadget { get { return "Creating Large Gadgets"; } }
    }
}
