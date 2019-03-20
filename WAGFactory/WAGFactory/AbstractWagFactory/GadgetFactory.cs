using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractWagFactory
{
    public class GadgetFactory : AbstractWAGFactory
    {
        public override IGadgetComponents CreateGadgetComponents()
        {
            return new GadgetComponents();
        }

        public override IWidgetComponents CreateWidgetComponents()
        {
            throw new NotImplementedException();
            //Gadget factory requesting widget factory.
        }

        public override ICreateSize CreatSize()
        {
            return new CreateSize();
        }
    }
}
