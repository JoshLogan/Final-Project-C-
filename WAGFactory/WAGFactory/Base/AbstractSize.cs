using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WAGFactory
{
    class AbstractSize : ISize
    {
        private string _size;

        public string Size
        {
            get
            {
                return _size;
            }
        }

        public AbstractSize(string size)
        {
            this._size = size;
        }

        public override string ToString()
        {
            return this.GetType().Name + " is " + _size;
        }
    }
}
