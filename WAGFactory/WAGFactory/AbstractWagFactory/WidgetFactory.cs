using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractWagFactory
{
    class WidgetFactory : AbstractWAGFactory
    {
        public override IWidgetComponents CreateWidgetComponents()
        {
            return new WidgetComponents();
        }
    }
}
