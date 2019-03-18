using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WAGFactory
{
    public abstract class AbstractWidget : AbstractWag
    {
        private FinishColor _typeColor;
        private ISelectSize _size;


        public FinishColor ColorType
        {
            get
            {
                return _typeColor;
            }
        }
        public ISelectSize GetWagSize
        {
            get
            {

                return _size;
            }
        }
        public AbstractWidget(FinishColor color) : base(color)
        {

        }

        public AbstractWidget(FinishColor color, ISelectSize size) : base(color, size)
        {

        }

        public AbstractWidget()
        {
        }
    }
}
