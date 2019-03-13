using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractWAGFactory
{
    public class WidgetComponents : IWidgetComponents
    {
        public string LeverParts { get { return "Levers for Widget."; } }
        public string SpringParts { get { return "Springs for Widget."; } }
        public string GearParts { get { return "Gears for Widget."; } }
    }
}
