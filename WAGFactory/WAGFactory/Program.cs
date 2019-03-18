using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WAGFactory;
using AbstractWagFactory;
using Builder;
using Decorator;
using Iterator;
using Base;

namespace WAGFactory
{
    class Program
    {
        static void Main(string[] args)
        {
            //AbstractWagDemo();
            //BuilderPatternDemo();
            // SmallWidget();
            // MediumWidget();
            // DecoratorPatternDemo();
            //  IteratorDemo();
            SizeSelectDemo();
        }

        private static void SizeSelectDemo()
        {
            IteratorDemo();


            SelectWagSize sws = new SelectWagSize();
            sws.WagSelection();

        }

        private static void IteratorDemo()
        {
            Console.WriteLine("=== Widgets ===");
            WidgetRange widgetRange = new WidgetRange();
            PrintIterator(widgetRange.GetEnumerator());
            Console.WriteLine("===============================================================");
            Console.WriteLine("=== Gadgets ===");
            GadgetRange gadgetRange = new GadgetRange();
            PrintIterator(gadgetRange.GetEnumerator());

        }

        public static void PrintIterator(IEnumerator<IWag> iter)
        {
            while (iter.MoveNext())
            {
                Console.WriteLine(iter.Current);
            }
        }

        private static void DecoratorPatternDemo()
        {
            IWag mySmallWidget = new SmallWidget(FinishColor.PlainBlack);
            Console.WriteLine(mySmallWidget);

            mySmallWidget = new CustomComponentsOption(mySmallWidget);
            Console.WriteLine(mySmallWidget);

            mySmallWidget = new EverythingGoldOption(mySmallWidget);
            Console.WriteLine(mySmallWidget);

        }

        private static void MediumWidget()
        {
            AbstractWidget widget = new MediumWidget(FinishColor.PaintedGreen);
            WagBuilder builder = new WidgetBuilder(widget);
            WagDirector director = new WidgetDirector();
            IWag mediumWidget = director.Build(builder);
            Console.WriteLine(mediumWidget);
        }

        private static void SmallWidget()
        {
            AbstractWidget widget = new SmallWidget();
            WagBuilder builder = new WidgetBuilder(widget);
            WagDirector director = new WidgetDirector();
            IWag smallWidget = director.Build(builder);
            Console.WriteLine(smallWidget);
        }

        private static void BuilderPatternDemo()
        {
            AbstractWidget abstractWidget = new SmallWidget(FinishColor.PlatinumPlated);
            WagBuilder wagBuilder = new WidgetBuilder(abstractWidget);
            WagDirector wagDirector = new WidgetDirector();
            IWag widget = wagDirector.Build(wagBuilder);
            Console.WriteLine(widget);

            AbstractGadget abstractGadget = new SmallGadget(FinishColor.PlainBlack, new SmallSize(4, true));
            WagBuilder builder = new GadgetBuilder(abstractGadget);
            WagDirector director = new GadgetDirector();
            IWag gadget = director.Build(builder);
            Console.WriteLine(gadget);
        }

        private static void AbstractWagDemo()
        {
            AbstractWAGFactory factory = new WidgetFactory();
            IWidgetComponents widgetComponents = factory.CreateWidgetComponents();
            Console.WriteLine(widgetComponents.GearParts);
            Console.WriteLine(widgetComponents.SpringParts);
            Console.WriteLine(widgetComponents.LeverParts);

            AbstractWAGFactory gFactory = new GadgetFactory();
            IGadgetComponents gadgetComponents = gFactory.CreateGadgetComponents();
            Console.WriteLine(gadgetComponents.Buttons);
            Console.WriteLine(gadgetComponents.Lights);
            Console.WriteLine(gadgetComponents.Switch);
            Console.WriteLine(gadgetComponents.Widgets);
        }
    }
}
