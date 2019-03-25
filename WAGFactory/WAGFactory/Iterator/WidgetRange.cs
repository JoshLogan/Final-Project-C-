using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WAGFactory;

namespace Iterator
{
    public class WidgetRange
    {
        private IList<IWag> _wags;

        public virtual IList<IWag> Range
        {
            get
            {
                return _wags;
            }
        }

        public WidgetRange()
        {
            _wags = new List<IWag>();

            _wags.Add(new SmallWidget(FinishColor.PlainWhite));
            _wags.Add(new MediumWidget(FinishColor.PlainBlack));
            _wags.Add(new LargeWidget(FinishColor.PlatedPlatinum));
            _wags.Add(new SmallWidget(FinishColor.PaintedChiefsRed));


        }

        public virtual IEnumerator<IWag> GetEnumerator()
        {
            return _wags.GetEnumerator();
        }


    }
}
