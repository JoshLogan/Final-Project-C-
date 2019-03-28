using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WAGFactory;


namespace Demo
{
    class OrderSummary
    {
        public void OrderConfirmation()
        {
            SmallGadget smallGadget = new SmallGadget();
            LargeGadget largeGadget = new LargeGadget();


            Console.WriteLine("+++++++++++++++++++++++++++++++++++- -Order Summary- -+++++++++++++++++++++++++++++++++++++++++++");
            Console.WriteLine("+++++++++++++++++++++++++++++++++++- **Review Order** -+++++++++++++++++++++++++++++++++++++++++++");

            Console.WriteLine(" ************ Widget & Gadget Corporation ************ ");
            Console.WriteLine(" *                                                   * ");
            Console.WriteLine(" ");
            Console.WriteLine(" ");
            Console.WriteLine(smallGadget.ToString());
            Console.WriteLine(largeGadget.ToString());
            Console.WriteLine(" ");
            Console.WriteLine(" ");
            Console.WriteLine(" Does this complete your Order?");


        }

    }
}
