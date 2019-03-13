using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WAGFactory
{
    public interface IWidget
    {
        ISize GetSize { get; }

        int NumberOf { get; }

        FinishColor ColorType { get; }

        decimal Price { get; }

        void Paint(FinishColor finish);

        void TestWidget();

        void CleanWidget();

    }
}
