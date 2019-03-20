using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractWagFactory
{
    public abstract class AbstractWAGFactory
    {
        public abstract IWidgetComponents CreateWidgetComponents();
        public abstract IGadgetComponents CreateGadgetComponents();
        public abstract ICreateSize CreatSize();
    }
}
