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
        private ISize _size;


        public FinishColor ColorType
        {
            get
            {
                return _typeColor;
            }
        }
        public ISize GetWagSize
        {
            get
            {

                return _size;
            }
        }
        public AbstractWidget(FinishColor color) : base(color)
        {

        }

        public AbstractWidget(FinishColor color, ISize size) : base(color, size)
        {

        }

        public AbstractWidget()
        {
        }
    }
}
