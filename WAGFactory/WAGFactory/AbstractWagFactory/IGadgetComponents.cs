using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractWagFactory
{
    public interface IGadgetComponents
    {
        string Switch { get; }
        string Buttons { get; }
        string Lights { get; }
        string Widgets { get; }
    }
}
