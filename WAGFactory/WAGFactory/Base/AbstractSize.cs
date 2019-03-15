using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WAGFactory
{
    class AbstractSize : ISize
    {
        private int _size;

        public int Size
        {
            get
            {
                return _size;
            }
        }

        public AbstractSize(int size)
        {
            _size = size;
        }

        public override string ToString()
        {
            return this.GetType().Name + " is " + _size;
        }
    }
}
