using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WAGFactory;

namespace Builder
{
    public class WidgetBuilder : WagBuilder
    {
        private AbstractWidget _abstractWidgetInProgress;

        public override IWag Widget
        {
            get
            {
                return _abstractWidgetInProgress;
            }
        }
        public WidgetBuilder(AbstractWidget widget)
        {
            this._abstractWidgetInProgress = widget;
        }
        public override void BuildWidgetParts()
        {
            Console.WriteLine("Building parts for Widget.");
        }
    }
}
