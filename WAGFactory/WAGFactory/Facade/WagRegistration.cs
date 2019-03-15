using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WAGFactory;


namespace Facade
{
    public class WagRegistration
    {
        private IWag _wag;

        public WagRegistration(IWag wag)
        {
            this._wag = wag;
        }

        public void AllocateWagNumber()
        {
            Console.WriteLine("Allocating Wag Number . . . ");
        }

    }
}
