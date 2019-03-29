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
using Facade;

namespace WAGFactory
{
    class Program
    {

        static void Main(string[] args)
        {

            //AbstractWagDemo();
            //BuilderPatternDemo();
            //SmallWidget();
            //MediumWidget();
            //DecoratorPatternDemo();
            //IteratorDemo();
            //FacadePatDemo();
            SizeSelectDemo();
        }

        private static void SizeSelectDemo()
        {
            AbstractWAGFactory factory = new WidgetFactory();
            IWidgetComponents widgetComponents = factory.CreateWidgetComponents();
            ICreateSize create = factory.CreatSize();
            AbstractWAGFactory gFactory = new GadgetFactory();
            IGadgetComponents gadgetComponents = gFactory.CreateGadgetComponents();
            ICreateSize createSize = gFactory.CreatSize();



            Console.WriteLine(" Welcome to our WAG Corporation. We are in the business of: ");
            Console.WriteLine("  ");
            Console.WriteLine(create.SmallWidget);
            Console.WriteLine(create.MediumWidget);
            Console.WriteLine(create.LargeWidget);
            Console.WriteLine(create.SmallGadget);
            Console.WriteLine(create.MediumGadget);
            Console.WriteLine(create.LargeGadget);
            Console.WriteLine("  ");
            Console.WriteLine("  ");
            Console.WriteLine(" Below is a list of our Products: ");
            Console.WriteLine("  ");
            ProductList();
            Console.WriteLine(" **The prices of these items are subject to change due to any custom or personal changes.");
            Console.WriteLine(" **All sales are final. *30 day Warranty. No refunds. ");
            SelectWagSize sws = new SelectWagSize();
            sws.WagSelection();
            Console.WriteLine(" ");
            Console.WriteLine("This concludes our Console Application of the WAG Corporation. I hope you enjoyed it!! Thank you for joining us today.");
            Console.ReadLine();
        }


        private static void FacadePatDemo()
        {
            WagFacade facade = new WagFacade();
            facade.PrepareForSale(new SmallGadget(FinishColor.PaintedChiefsRed));
        }


        private static void ProductList()
        {
            Console.WriteLine("====== Widgets =====");
            Console.WriteLine(" ");
            WidgetRange widgetRange = new WidgetRange();
            PrintIterator(widgetRange.GetEnumerator());
            Console.WriteLine(" ");
            Console.WriteLine("==================================================================================================");
            Console.WriteLine(" ");
            Console.WriteLine("======= Gadgets =======");
            Console.WriteLine(" ");
            GadgetRange gadgetRange = new GadgetRange();
            PrintIterator(gadgetRange.GetEnumerator());
            Console.WriteLine(" ");
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
            AbstractWidget abstractWidget = new SmallWidget(FinishColor.PlatedPlatinum);
            WagBuilder wagBuilder = new WidgetBuilder(abstractWidget);
            WagDirector wagDirector = new WidgetDirector();
            IWag widget = wagDirector.Build(wagBuilder);
            Console.WriteLine(widget);

            AbstractGadget abstractGadget = new SmallGadget(FinishColor.PlainBlack);
            WagBuilder builder = new GadgetBuilder(abstractGadget);
            WagDirector director = new GadgetDirector();
            IWag gadget = director.Build(builder);
            Console.WriteLine(gadget);
        }

        private static void AbstractWagDemo()
        {
            AbstractWAGFactory factory = new WidgetFactory();
            IWidgetComponents widgetComponents = factory.CreateWidgetComponents();
            ICreateSize create = factory.CreatSize();
            Console.WriteLine(widgetComponents.GearParts);
            Console.WriteLine(widgetComponents.SpringParts);
            Console.WriteLine(widgetComponents.LeverParts);
            Console.WriteLine(create.SmallWidget);
            Console.WriteLine(create.MediumWidget);
            Console.WriteLine(create.LargeWidget);



            AbstractWAGFactory gFactory = new GadgetFactory();
            IGadgetComponents gadgetComponents = gFactory.CreateGadgetComponents();
            ICreateSize createSize = gFactory.CreatSize();
            Console.WriteLine(gadgetComponents.Buttons);
            Console.WriteLine(gadgetComponents.Lights);
            Console.WriteLine(gadgetComponents.Switch);
            Console.WriteLine(gadgetComponents.Widgets);
            Console.WriteLine(createSize.SmallGadget);
            Console.WriteLine(createSize.MediumGadget);
            Console.WriteLine(createSize.LargeGadget);

        }

    }
}
