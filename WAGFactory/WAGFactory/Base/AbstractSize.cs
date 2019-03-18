using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WAGFactory
{
    public class AbstractSize : ISize
    {
        private int _numberOf;
        private bool _isSmall;

        public int NumberOf
        {
            get
            {
                return _numberOf;
            }
        }
        public bool IsSmall
        {
            get
            {
                return _isSmall;
            }
        }

        public AbstractSize(int numberOf, bool isSmall)
        {
            this._numberOf = numberOf;
            this._isSmall = isSmall;
        }

        public override string ToString()
        {
            return this.GetType().Name + ". The size is " + _isSmall + " and there are " + _numberOf + " of them.";
        }
    }
}
