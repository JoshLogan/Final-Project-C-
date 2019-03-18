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

        SmallWidget sw = new SmallWidget();

        public void WagSelection()
        {
            Console.WriteLine(" Would you like to order a Widget or Gadget");
            wagSelection = Convert.ToString(Console.ReadLine());

            if (wagSelection.ToLower() == "small widget")
            {
                Console.WriteLine("Creating a Small Widget.");
                Console.WriteLine(sw.ToString());


            }
        }

    }
}
