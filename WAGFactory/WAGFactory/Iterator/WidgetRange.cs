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

            _wags.Add(new SmallWidget(FinishColor.PlainWhite));
            _wags.Add(new SmallWidget(FinishColor.PlainBlack));
            _wags.Add(new SmallWidget(FinishColor.PlainGray));
            _wags.Add(new SmallWidget(FinishColor.PaintedChiefsRed));
            _wags.Add(new SmallWidget(FinishColor.PaintedRoyalBlue));
            _wags.Add(new SmallWidget(FinishColor.PaintedYellow));
            _wags.Add(new SmallWidget(FinishColor.PaintedGreen));
            _wags.Add(new SmallWidget(FinishColor.PaintedPink));
            _wags.Add(new SmallWidget(FinishColor.PlatedCamouflage));
            _wags.Add(new SmallWidget(FinishColor.PlatedGold));
            _wags.Add(new SmallWidget(FinishColor.PlatedPlatinum));
            _wags.Add(new SmallWidget(FinishColor.PlatedRhodium));
            _wags.Add(new SmallWidget(FinishColor.PlatedRoseGold));
            _wags.Add(new SmallWidget(FinishColor.PlatedSilver));
            _wags.Add(new MediumWidget(FinishColor.PaintedChiefsRed));
            _wags.Add(new MediumWidget(FinishColor.PaintedRoyalBlue));
            _wags.Add(new MediumWidget(FinishColor.PaintedPink));
            _wags.Add(new MediumWidget(FinishColor.PaintedGreen));
            _wags.Add(new MediumWidget(FinishColor.PaintedYellow));
            _wags.Add(new MediumWidget(FinishColor.PlainBlack));
            _wags.Add(new MediumWidget(FinishColor.PlainGray));
            _wags.Add(new MediumWidget(FinishColor.PlainWhite));
            _wags.Add(new MediumWidget(FinishColor.PlatedCamouflage));
            _wags.Add(new MediumWidget(FinishColor.PlatedGold));
            _wags.Add(new MediumWidget(FinishColor.PlatedPlatinum));
            _wags.Add(new MediumWidget(FinishColor.PlatedRhodium));
            _wags.Add(new MediumWidget(FinishColor.PlatedRoseGold));
            _wags.Add(new MediumWidget(FinishColor.PlatedSilver));
            _wags.Add(new LargeWidget(FinishColor.PaintedPink));
            _wags.Add(new LargeWidget(FinishColor.PaintedYellow));
            _wags.Add(new LargeWidget(FinishColor.PaintedGreen));
            _wags.Add(new LargeWidget(FinishColor.PaintedRoyalBlue));
            _wags.Add(new LargeWidget(FinishColor.PaintedGreen));
            _wags.Add(new LargeWidget(FinishColor.PaintedChiefsRed));
            _wags.Add(new LargeWidget(FinishColor.PlatedSilver));
            _wags.Add(new LargeWidget(FinishColor.PlatedRoseGold));
            _wags.Add(new LargeWidget(FinishColor.PlatedRhodium));
            _wags.Add(new LargeWidget(FinishColor.PlatedPlatinum));
            _wags.Add(new LargeWidget(FinishColor.PlatedGold));
            _wags.Add(new LargeWidget(FinishColor.PlatedCamouflage));
            _wags.Add(new LargeWidget(FinishColor.PlainBlack));
            _wags.Add(new LargeWidget(FinishColor.PlainGray));
            _wags.Add(new MediumWidget(FinishColor.PlainWhite));


        }

        public virtual IEnumerator<IWag> GetEnumerator()
        {
            return _wags.GetEnumerator();
        }


    }
}
