using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AbstractWAGFactory;
using Builder;

namespace WAGFactory
{
    class Program
    {
        static void Main(string[] args)
        {
            AbstractWagDemo();
            BuilderPatternDemo();
        }

        private static void BuilderPatternDemo()
        {
            AbstractWidget abstractWidget = new SmallWidget(2);
            WagBuilder wagBuilder = new WidgetBuilder(abstractWidget);
            WagDirector wagDirector = new WidgetDirector();
            IWidget widget = wagDirector.Build(wagBuilder);
            Console.WriteLine(widget);
        }

        private static void AbstractWagDemo()
        {
            AbstractWAGFactory.AbstractWAGFactory factory = new WidgetFactory();
            IWidgetComponents widgetComponents = factory.CreateWidgetComponents();
            Console.WriteLine(widgetComponents.GearParts);
            Console.WriteLine(widgetComponents.SpringParts);
            Console.WriteLine(widgetComponents.LeverParts);
        }
    }
}
