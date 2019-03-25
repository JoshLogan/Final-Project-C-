using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Singleton;

namespace WAGFactory
{
    public abstract class AbstractWag : IWag
    {
        private FinishColor _finishColor;




        public FinishColor TypeColor
        {
            get { return _finishColor; }
        }



        public abstract decimal Price { get; }



        public AbstractWag() { }

        public AbstractWag(FinishColor color)
        {
            this._finishColor = color;
        }

        public virtual void Paint(FinishColor color)
        {
            this._finishColor = color;
        }

        public override string ToString()
        {
            return "Abstract Wag with a Finish that is " + _finishColor + " and the Price is $" + Price;
        }

        public void CleanWidget()
        {
            throw new NotImplementedException();
        }

        public void CleanGadget()
        {
            throw new NotImplementedException();
        }

        public void GatherOrder()
        {
            throw new NotImplementedException();
        }

        public void PlaceOrder()
        {
            throw new NotImplementedException();
        }
    }
}
