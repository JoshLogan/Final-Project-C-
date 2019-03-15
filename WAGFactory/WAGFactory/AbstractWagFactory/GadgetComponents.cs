using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WAGFactory;

namespace AbstractWagFactory
{
    public class GadgetComponents : IGadgetComponents
    {
        public string Switch { get { return "Switch for Gadget."; } }

        public string Buttons { get { return "Button for Gadget."; } }

        public string Lights { get { return "Light for Gadget."; } }

        public string Widgets { get { return "Gathering Widgets for Gadget"; } }

    }
}
