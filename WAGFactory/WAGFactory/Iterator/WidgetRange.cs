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

            _wags.Add(new SmallWidget());
            _wags.Add(new MediumWidget());
            _wags.Add(new LargeWidget());


        }

        public virtual IEnumerator<IWag> GetEnumerator()
        {
            return _wags.GetEnumerator();
        }


    }
}
