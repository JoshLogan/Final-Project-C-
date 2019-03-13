using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WAGFactory
{
    public interface IWidget
    {
        int NumberOf { get; }

        bool IsSmall { get; }

        FinishColor ColorType { get; }

        decimal Price { get; }

        void Paint(FinishColor finish);

        void TestWidget();

        void CleanWidget();

    }
}
