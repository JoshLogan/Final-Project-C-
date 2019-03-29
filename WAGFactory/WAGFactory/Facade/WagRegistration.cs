using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WAGFactory;
using Singleton;


namespace Facade
{
    public class WagRegistration
    {
        private IWag _wag;
        public string serial { get; private set; }

        public WagRegistration(IWag wag)
        {
            this._wag = wag;
            
        }

        public void AllocateWagNumber()
        {
            serial = WAGSerialGen.Instance.NextSerial(WaGs.smallwidget);
            Console.WriteLine("Allocating Wag Number . . . ");
            Console.WriteLine(serial);
            serial = WAGSerialGen.Instance.NextSerial(WaGs.smallwidget);
            Console.WriteLine(serial);
        }

    }
}
