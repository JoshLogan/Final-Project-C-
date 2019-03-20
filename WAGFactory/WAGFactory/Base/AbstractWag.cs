using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WAGFactory
{
    public abstract class AbstractWag : IWag
    {
        private FinishColor _finishColor;
        private ISelectSize _size;

        public FinishColor TypeColor
        {
            get { return _finishColor; }
        }

        public ISelectSize GetWagSize
        {
            get { return _size; }
        }

        public abstract decimal Price { get; }

        public int NumberOf { get; }

        public bool IsSmall { get; }

        public AbstractWag() { }

        public AbstractWag(FinishColor color)
        { this._finishColor = color; }

        public AbstractWag(FinishColor color, ISelectSize size)
        {
            this._finishColor = color;
            this._size = size;
        }

        public virtual void Paint(FinishColor color)
        {
            this._finishColor = color;
        }

        public override string ToString()
        {
            return this.GetType().Name + ": With a Finish that is " + _finishColor + " and the Price is $" + Price;
        }


    }
}
