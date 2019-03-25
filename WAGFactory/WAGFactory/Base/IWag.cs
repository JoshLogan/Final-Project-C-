using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WAGFactory
{
    public interface IWag
    {


        FinishColor TypeColor { get; }

        decimal Price { get; }

        void Paint(FinishColor color);

        void CleanWidget();
        void CleanGadget();
        void GatherOrder();
        void PlaceOrder();


    }
}
