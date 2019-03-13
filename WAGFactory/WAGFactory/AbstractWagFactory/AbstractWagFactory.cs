using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractWAGFactory
{
    public abstract class AbstractWAGFactory
    {
        public abstract IWidgetComponents CreateWidgetComponents();

    }
}
