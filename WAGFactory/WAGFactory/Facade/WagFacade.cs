using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WAGFactory;

namespace Facade
{
    public class WagFacade
    {
        public void PrepareForSale(IWag wag)
        {
            WagRegistration wagReg = new WagRegistration(wag);
            wagReg.AllocateWagNumber();

            WagDocumentation.PrintSpecSheet(wag);

            wag.CleanWidget();
            wag.PrepWidget();
            wag.TestWidget();
            wag.InstallWidget();
        }
    }
}
