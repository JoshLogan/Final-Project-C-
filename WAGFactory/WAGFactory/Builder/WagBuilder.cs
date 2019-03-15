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
        public virtual void BuildWidgetParts() { }

    }
}
