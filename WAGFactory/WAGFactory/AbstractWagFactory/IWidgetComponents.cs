using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractWAGFactory
{
    public interface IWidgetComponents
    {
        string LeverParts { get; }
        string SpringParts { get; }
        string GearParts { get; }
    }
}
