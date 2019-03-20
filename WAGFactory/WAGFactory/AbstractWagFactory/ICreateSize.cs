using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractWagFactory
{
    public interface ICreateSize
    {
        string SmallWidget { get; }
        string MediumWidget { get; }
        string LargeWidget { get; }
        string SmallGadget { get; }
        string MediumGadget { get; }
        string LargeGadget { get; }
    }
}
