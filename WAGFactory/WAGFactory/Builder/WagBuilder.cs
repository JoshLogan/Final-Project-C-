using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WAGFactory;

namespace Builder
{
    public abstract class WagBuilder
    {
        public abstract IWag Widget { get; }
        public abstract IWag Gadget { get; }
        public virtual void BuildWidgetParts() { }
        public virtual void BuildGadgetParts() { }
    }
}
