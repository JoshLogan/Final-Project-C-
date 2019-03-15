using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WAGFactory
{
    class LargeWidget : AbstractWidget
    {
        public LargeWidget()
        {
        }

        public LargeWidget(ISize size) : base(size)
        {
        }

        public LargeWidget(ISize size, FinishColor color) : base(size, color)
        {
        }

        public override ISize Size => throw new NotImplementedException();

        public override decimal Price => base.Price;

        public override void CleanWidget()
        {
            base.CleanWidget();
        }

        public override void InstallWidget()
        {
            base.InstallWidget();
        }

        public override void Paint(FinishColor color)
        {
            base.Paint(color);
        }

        public override void PrepWidget()
        {
            base.PrepWidget();
        }

        public override void TestWidget()
        {
            base.TestWidget();
        }

        public override string ToString()
        {
            return base.ToString();
        }
    }
}
