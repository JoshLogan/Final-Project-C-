using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WAGFactory
{
    public abstract class AbstractWag : IWag
    {
        private ISize _size;

        private FinishColor _typeColor;

        public FinishColor TypeColor
        {
            get
            {
                return _typeColor;
            }
        }

        public ISize GetSize
        {
            get
            {
                return _size;
            }
        }

        public abstract decimal Price { get; }


        public AbstractWag(ISize size)
        {
            _size = size;
        }

        public AbstractWag(FinishColor typeColor)
        {
            _typeColor = typeColor;
        }

        public AbstractWag(ISize size, FinishColor typeColor)
        {
            _size = size;
            _typeColor = typeColor;
        }

        public virtual void CleanWidget()
        {
            Console.WriteLine("Cleaning widget . . . ");
        }

        public virtual void InstallWidget()
        {
            Console.WriteLine("Installing widget . . .");
        }

        public virtual void Paint(FinishColor color)
        {
            _typeColor = color;
        }

        public override string ToString()
        {
            return this.GetType().Name + "Widget Finish and color is " + _typeColor + " and the Price is $" + Price;
        }

        public virtual void PrepWidget()
        {
            Console.WriteLine("Preping widget . . . ");
        }

        public virtual void TestWidget()
        {
            Console.WriteLine("Testing widget . . . ");
        }

        public AbstractWag()
        {

        }
    }
}
