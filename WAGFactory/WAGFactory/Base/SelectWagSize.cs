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
        string answer3;
        string answer4;

        SmallWidget sw = new SmallWidget();
        SmallGadget sg = new SmallGadget();
        MediumWidget mw = new MediumWidget();
        MediumGadget mg = new MediumGadget();
        LargeWidget lw = new LargeWidget();
        LargeGadget lg = new LargeGadget();

        public void WagSelection()
        {
            Console.WriteLine("   ");
            Console.WriteLine("Great!! LETS GET STARTED!");
            Console.WriteLine("   ");
            Console.WriteLine("Would you like to order a Widget or a Gadget?");
            Console.WriteLine("   ");
            Console.WriteLine("---Please input Widget for Widgets List  ");
            Console.WriteLine("     or input Gadget for Gadgets List");
            Console.WriteLine("   ");
            answer = Convert.ToString(Console.ReadLine());
            Console.WriteLine(" ");
            if (answer.ToLower() == "widget")
            {
                Console.WriteLine(" ");
                Console.WriteLine("We offer these three types: ");
                Console.WriteLine("Small Widget");
                Console.WriteLine("Medium Widget");
                Console.WriteLine("Large Widget");
                Console.WriteLine(" ");
                Console.WriteLine("What size and type would you like?");
                Console.WriteLine("  ");
                sizeSelected = Convert.ToString(Console.ReadLine());
                Console.WriteLine(" ");
                wagSelection = sizeSelected;
                if (wagSelection.ToLower() == "small widget")
                {
                    Console.WriteLine("Creating a Small Widget.");
                    Console.WriteLine(sw.ToString());
                    Console.WriteLine(" ");
                }
                else if (wagSelection.ToLower() == "medium widget")
                {
                    Console.WriteLine("Creating a Medium Widget.");
                    Console.WriteLine(mw.ToString());
                    Console.WriteLine(" ");
                }
                else if (wagSelection.ToLower() == "large widget")
                {
                    Console.WriteLine("Creating a Large Widget.");
                    Console.WriteLine(lw.ToString());
                    Console.WriteLine(" ");
                }
                else
                {
                    Console.WriteLine(" ");
                    Console.WriteLine("***INVALID RESPONSE****");
                    Console.WriteLine("***Please Input using format: \"Small Widget\"");
                    WidgetSelect();
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
                Console.WriteLine(" ");
                sizeSelected = Convert.ToString(Console.ReadLine());
                Console.WriteLine(" ");
                wagSelection = sizeSelected;
                if (wagSelection.ToLower() == "small gadget")
                {
                    Console.WriteLine("Creating a Small Gadget.");
                    Console.WriteLine(sg.ToString());
                    Console.WriteLine(" ");
                }
                else if (wagSelection.ToLower() == "medium gadget")
                {
                    Console.WriteLine("Creating a Medium Gadget.");
                    Console.WriteLine(mg.ToString());
                    Console.WriteLine(" ");
                }
                else if (wagSelection.ToLower() == "large gadget")
                {
                    Console.WriteLine("Creating a Large Gadget.");
                    Console.WriteLine(lg.ToString());
                    Console.WriteLine(" ");
                }
                else
                {
                    Console.WriteLine(" ");
                    Console.WriteLine("***INVALID RESPONSE****");
                    Console.WriteLine("***Please Input using format: \"Small Gadget\"");
                    GadgetSelect();
                }
            }

            Console.WriteLine(" Would you like to add more products to your Order today? Or Confirm Your Order? ");
            Console.WriteLine(" ");
            Console.WriteLine(" ** Input \"Add To ORder\" to add more products. ** ");
            Console.WriteLine(" ** Input \"Confirm Order\" to see your ORder Summary. ** ");
            Console.WriteLine(" ");
            answer2 = Convert.ToString(Console.ReadLine());
            Console.WriteLine(" ");
            if (answer2.ToLower() == "add to order")
            {
                Console.WriteLine(" ");
                Console.WriteLine(" Redirecting you now...");
                AddToOrder();
            }
            else if (answer2.ToLower() == "confirm order")
            {
                Console.WriteLine(" ");
                Console.WriteLine("Thank for you order today! ");
                Console.WriteLine("Redirecting to Order Summary..");
                Console.WriteLine(" ");
                OSumm();
            }
           
           
        }
        public void GadgetSelect()
        {
            Console.WriteLine(" ");
            Console.WriteLine("We offer these three types: ");
            Console.WriteLine(" ");
            Console.WriteLine("Small Gadget");
            Console.WriteLine("Medium Gadget");
            Console.WriteLine("Large Gadget");
            Console.WriteLine(" ");
            Console.WriteLine("What size and type would you like?");
            Console.WriteLine(" ");
            sizeSelected = Convert.ToString(Console.ReadLine());
            wagSelection = sizeSelected;
            if (wagSelection.ToLower() == "small gadget")
            {
                Console.WriteLine("Creating a Small Gadget.");
                Console.WriteLine(sg.ToString());
                Console.WriteLine(" ");
            }
            else if (wagSelection.ToLower() == "medium gadget")
            {
                Console.WriteLine("Creating a Medium Gadget.");
                Console.WriteLine(mg.ToString());
                Console.WriteLine(" ");
            }
            else if (wagSelection.ToLower() == "large gadget")
            {
                Console.WriteLine("Creating a Large Gadget.");
                Console.WriteLine(lg.ToString());
                Console.WriteLine(" ");
            }
            else
            {
                Console.WriteLine(" ");
                Console.WriteLine("***INVALID RESPONSE****");
                Console.WriteLine("***Please Input using format: \"Small Gadget\"");
                GadgetSelect();
            }
        }
        public void WidgetSelect()
        {
            Console.WriteLine(" ");
            Console.WriteLine("We offer these three types: ");
            Console.WriteLine(" ");
            Console.WriteLine("Small Widget");
            Console.WriteLine("Medium Widget");
            Console.WriteLine("Large Widget");
            Console.WriteLine(" ");
            Console.WriteLine("What size and type would you like?");
            Console.WriteLine("  ");
            sizeSelected = Convert.ToString(Console.ReadLine());
            Console.WriteLine(" ");
            wagSelection = sizeSelected;
            if (wagSelection.ToLower() == "small widget")
            {
                Console.WriteLine("Creating a Small Widget.");
                Console.WriteLine(sw.ToString());
                Console.WriteLine(" ");
            }
            else if (wagSelection.ToLower() == "medium widget")
            {
                Console.WriteLine("Creating a Medium Widget.");
                Console.WriteLine(mw.ToString());
                Console.WriteLine(" ");
            }
            else if (wagSelection.ToLower() == "large widget")
            {
                Console.WriteLine("Creating a Large Widget.");
                Console.WriteLine(lw.ToString());
                Console.WriteLine(" ");
            }
            else
            {
                Console.WriteLine(" ");
                Console.WriteLine(" ");
                Console.WriteLine("***INVALID RESPONSE****");
                Console.WriteLine("***Please Input using format: \"Small Widget\"");
                WidgetSelect();
            }
        }
        public void AddToOrder()
        {
            SelectWagSize select = new SelectWagSize();
            select.WagSelection();
        }
        public void OSumm()
        { 
            OrderConfirmation();
        }

        public void OrderConfirmation()
        {
            SmallGadget smallGadget = new SmallGadget();
            LargeGadget largeGadget = new LargeGadget();

            Console.WriteLine(" ");

            Console.WriteLine("++++++++++++++- **Review Order** -++++++++++++++++++++++");
            Console.WriteLine("   ");
            Console.WriteLine(" ************ Widget & Gadget Corporation ************ ");
            Console.WriteLine(" *          1234 OutStake Rd, KC, MO, 64110          * ");
            Console.WriteLine(" *             Phone Number: 816-555-5555            * ");
            Console.WriteLine(" *                Fax: 816-444-4444       bbbbb      * ");
            Console.WriteLine(" *                                      BBbBBBbBB    * ");
            Console.WriteLine(" *    ww       ww     a       gggg     BBBBbBbBBBB   * ");
            Console.WriteLine(" *    ww       ww    a a     g         bB  bbb  Bb   * ");
            Console.WriteLine(" *    ww   w   ww   aaaaa   gg   gg        bbb       * ");
            Console.WriteLine(" *     ww www ww    a   a    g    g       bbBbb      * ");
            Console.WriteLine(" *       w   w      a   a     gggg    b  bbBBBbb  b  * ");
            Console.WriteLine(" *                                     bbbbBBBbbbb   * ");
            Console.WriteLine(" ***************************************************** ");
            Console.WriteLine(" * Gadget Size: Small Gadget ...............  Qty: 1 * ");
            Console.WriteLine(" * Finish: Plain ..................................  * ");
            Console.WriteLine(" * Color: Black ..........................  $630.00  * ");
            Console.WriteLine(" * Additional                                        * ");
            Console.WriteLine(" * Power Source: Battery ................... $50.00  * ");
            Console.WriteLine(" *                                                   * ");
            Console.WriteLine(" * Added ITEM                                        * ");
            Console.WriteLine(" * Gadget Size: Large Gadget ................ Qty: 1 * ");
            Console.WriteLine(" * Finish: Plated                                    * ");
            Console.WriteLine(" * Color: Rose Gold ..................... $3,935.00  * ");
            Console.WriteLine(" * Additional                                        * ");
            Console.WriteLine(" * Power Source: Generator ...............  $200.00  * ");
            Console.WriteLine(" * Small Widgets Parts Pack  .............  $250.00  * ");
            Console.WriteLine(" *                                                   * ");
            Console.WriteLine(" ***************************************************** ");
            Console.WriteLine(" ");
            Console.WriteLine(" Does this complete your Order?");
            Console.WriteLine(" ");
            answer3 = Convert.ToString(Console.ReadLine());
            if (answer3.ToLower() == "yes")
            {
                Console.WriteLine(" ");
                Console.WriteLine(" ");
                Console.WriteLine("++++++++++++++- -Order Summary- -+++++++++++++++++++++++");
                Console.WriteLine("   ");
                Console.WriteLine(" ************ Widget & Gadget Corporation ************ ");
                Console.WriteLine(" *          1234 OutStake Rd, KC, MO, 64110          * ");
                Console.WriteLine(" *             Phone Number: 816-555-5555            * ");
                Console.WriteLine(" *                Fax: 816-444-4444       bbbbb      * ");
                Console.WriteLine(" *                                      BBbBBBbBB    * ");
                Console.WriteLine(" *    ww       ww     a       gggg     BBBBbBbBBBB   * ");
                Console.WriteLine(" *    ww       ww    a a     g         bB  bbb  Bb   * ");
                Console.WriteLine(" *    ww   w   ww   aaaaa   gg   gg        bbb       * ");
                Console.WriteLine(" *     ww www ww    a   a    g    g       bbBbb      * ");
                Console.WriteLine(" *       w   w      a   a     gggg    b  bbBBBbb  b  * ");
                Console.WriteLine(" *                                     bbbbBBBbbbb   * ");
                Console.WriteLine(" ***************************************************** ");
                Console.WriteLine(" * Gadget Size: Small Gadget ...............  Qty: 1 * ");
                Console.WriteLine(" * Finish: Plain ..................................  * ");
                Console.WriteLine(" * Color: Black ..........................  $630.00  * ");
                Console.WriteLine(" * Serial Number: " + smallGadget.serial + "                         * ");
                Console.WriteLine(" * Additional                                        * ");
                Console.WriteLine(" * Power Source: Battery ................... $50.00  * ");
                Console.WriteLine(" *                                                   * ");
                Console.WriteLine(" * Added ITEM                                        * ");
                Console.WriteLine(" * Gadget Size: Large Gadget ................ Qty: 1 * ");
                Console.WriteLine(" * Finish: Plated                                    * ");
                Console.WriteLine(" * Color: Rose Gold ..................... $3,935.00  * ");
                Console.WriteLine(" * Serial Number: " + largeGadget.serial + "                         * ");
                Console.WriteLine(" * Additional                                        * ");
                Console.WriteLine(" * Power Source: Generator ...............  $200.00  * ");
                Console.WriteLine(" * Small Widgets Parts Pack  .............  $250.00  * ");
                Console.WriteLine(" *                                                   * ");
                Console.WriteLine(" * Total Number of Items ..................       2  * ");
                Console.WriteLine(" * Amount before Tax ...................  $4,965.00  * ");
                Console.WriteLine(" *                                                   * ");
                Console.WriteLine(" ***************************************************** ");
                Console.WriteLine(" *                                                   * ");
                Console.WriteLine(" *     SubTotal ........................  $4,965.00  * ");
                Console.WriteLine(" *    Sales Tax ............................ 658.45  * ");
                Console.WriteLine(" *   Amount Due ........................  $5,623.45  * ");
                Console.WriteLine(" *                                                   * ");
                Console.WriteLine(" *                                                   * ");
                Console.WriteLine(" ***************************************************** ");

                Console.WriteLine(" ");
                Console.WriteLine(" ");

                Console.WriteLine("Thanks for ordering at the WAG Corporation.");
                Console.WriteLine("Processing your items for delivery . . . .");
                Console.WriteLine("Your order will be shipped and delivered within 24 hours.");
                Console.WriteLine(" ");
            }
            else if (answer3.ToLower() == "no")
            {
                Console.WriteLine(" ");
                Console.WriteLine("What would you like to do?: " +
                    "ADD TO ORDER, OR REVIEW YOUR ORDER?");
                Console.WriteLine(" ");
                answer4 = Convert.ToString(Console.ReadLine());
                if (answer4.ToLower() == "add to order")
                {
                    Console.WriteLine(" ");
                    Console.WriteLine("One moment. Please Wait..");
                    AddToOrder();
                }
                else if (answer4.ToLower() == "review order")
                {
                    Console.WriteLine(" ");
                    Console.WriteLine("One moment. Please Wait..");
                    OSumm();
                }
            }
        }
    }

}

