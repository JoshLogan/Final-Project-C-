using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WAGFactory
{
    public interface IWag : ISize
    {
        ISize GetWagSize { get; }

        FinishColor ColorType { get; }

        decimal Price { get; }

        void Paint(FinishColor color);



    }
}
