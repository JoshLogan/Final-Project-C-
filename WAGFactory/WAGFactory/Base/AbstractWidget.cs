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



        public FinishColor TypeColor
        {
            get
            {
                return _typeColor;
            }
        }

        public AbstractWidget(FinishColor color) : base(color)
        {

        }



        public AbstractWidget()
        {
        }
    }
}
