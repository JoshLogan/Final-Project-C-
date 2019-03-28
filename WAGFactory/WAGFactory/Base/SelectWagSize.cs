using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WAGFactory;


namespace Base
{
    class SelectWagSize
    {
        string wagSelection;
        string sizeSelected;
        string answer;
        string answer2;


        SmallWidget sw = new SmallWidget();
        SmallGadget sg = new SmallGadget();
        MediumWidget mw = new MediumWidget();
        MediumGadget mg = new MediumGadget();
        LargeWidget lw = new LargeWidget();
        LargeGadget lg = new LargeGadget();

        public void WagSelection()
        {
            Console.WriteLine("   ");
            Console.WriteLine("Would you like to order a Widget or a Gadget?");
            answer = Convert.ToString(Console.ReadLine());
            if (answer.ToLower() == "widget")
            {
                Console.WriteLine(" ");
                Console.WriteLine("We offer these three types: ");
                Console.WriteLine("Small Widget");
                Console.WriteLine("Medium Widget");
                Console.WriteLine("Large Widget");
                Console.WriteLine(" ");
                Console.WriteLine("What size and type would you like?");
                sizeSelected = Convert.ToString(Console.ReadLine());
                wagSelection = sizeSelected;
                if (wagSelection.ToLower() == "small widget")
                {
                    Console.WriteLine("Creating a Small Widget.");
                    Console.WriteLine(sw.ToString());
                }
                else if (wagSelection.ToLower() == "medium widget")
                {
                    Console.WriteLine("Creating a Medium Widget.");
                    Console.WriteLine(mw.ToString());
                }
                else if (wagSelection.ToLower() == "large widget")
                {
                    Console.WriteLine("Creating a Large Widget.");
                    Console.WriteLine(lw.ToString());
                }

            }
            else if (answer.ToLower() == "gadget")
            {
                Console.WriteLine(" ");
                Console.WriteLine("We offer these three types: ");
                Console.WriteLine("Small Gadget");
                Console.WriteLine("Medium Gadget");
                Console.WriteLine("Large Gadget");
                Console.WriteLine(" ");
                Console.WriteLine("What size and type would you like?");
                sizeSelected = Convert.ToString(Console.ReadLine());
                wagSelection = sizeSelected;
                if (wagSelection.ToLower() == "small gadget")
                {
                    Console.WriteLine("Creating a Small Gadget.");
                    Console.WriteLine(sg.ToString());
                }
                else if (wagSelection.ToLower() == "medium gadget")
                {
                    Console.WriteLine("Creating a Medium Gadget.");
                    Console.WriteLine(mg.ToString());
                }
                else if (wagSelection.ToLower() == "large gadget")
                {
                    Console.WriteLine("Creating a Large Gadget.");
                    Console.WriteLine(lg.ToString());
                }
            }

            Console.WriteLine(" Would you like to add more products to your Order today? Or Confirm Your Order? ");
            answer2 = Convert.ToString(Console.ReadLine());
            if (answer2.ToLower() == "add to order")
            {
                Console.WriteLine(" Redirecting you now...");
                AddToOrder();
            }
            else if (answer2.ToLower() == "confirm order")
            {
                Console.WriteLine("Thank you for placing ");
                Console.WriteLine("Redirecting to Order Summary..");
                OSumm();
            }
           
           
        }
        public void AddToOrder()
        {
            SelectWagSize select = new SelectWagSize();
            select.WagSelection();
        }
        public void OSumm()
        {
            Demo.OrderSummary order = new Demo.OrderSummary();
            order.OrderConfirmation();
        }


    }

}

