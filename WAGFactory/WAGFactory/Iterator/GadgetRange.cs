using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WAGFactory;

namespace Iterator
{
    public class GadgetRange
    {
        private IWag[] _wags;

        public virtual IWag[] Range
        {
            get { return _wags; }
        }

        public GadgetRange()
        {
            _wags = new IWag[43];

            _wags[0] = new SmallGadget(FinishColor.PaintedRoyalBlue);
            _wags[1] = new SmallGadget(FinishColor.PaintedGreen);
            _wags[2] = new SmallGadget(FinishColor.PaintedChiefsRed);
            _wags[3] = new SmallGadget(FinishColor.PaintedPink);
            _wags[4] = new SmallGadget(FinishColor.PaintedYellow);
            _wags[5] = new SmallGadget(FinishColor.PlatedRoseGold);
            _wags[6] = new SmallGadget(FinishColor.PlatedSilver);
            _wags[7] = new SmallGadget(FinishColor.PlatedGold);
            _wags[8] = new SmallGadget(FinishColor.PlatedRhodium);
            _wags[9] = new SmallGadget(FinishColor.PlatedPlatinum);
            _wags[10] = new SmallGadget(FinishColor.PlatedCamouflage);
            _wags[11] = new SmallGadget(FinishColor.PlainWhite);
            _wags[12] = new SmallGadget(FinishColor.PlainGray);
            _wags[13] = new SmallGadget(FinishColor.PlainBlack);
            _wags[15] = new MediumGadget(FinishColor.PaintedRoyalBlue);
            _wags[16] = new MediumGadget(FinishColor.PaintedGreen);
            _wags[17] = new MediumGadget(FinishColor.PaintedChiefsRed);
            _wags[18] = new MediumGadget(FinishColor.PaintedPink);
            _wags[19] = new MediumGadget(FinishColor.PaintedYellow);
            _wags[20] = new MediumGadget(FinishColor.PlatedRoseGold);
            _wags[21] = new MediumGadget(FinishColor.PlatedSilver);
            _wags[22] = new MediumGadget(FinishColor.PlatedGold);
            _wags[23] = new MediumGadget(FinishColor.PlatedRhodium);
            _wags[24] = new MediumGadget(FinishColor.PlatedPlatinum);
            _wags[25] = new MediumGadget(FinishColor.PlatedCamouflage);
            _wags[26] = new MediumGadget(FinishColor.PlainWhite);
            _wags[27] = new MediumGadget(FinishColor.PlainGray);
            _wags[28] = new MediumGadget(FinishColor.PlainBlack);
            _wags[29] = new LargeGadget(FinishColor.PaintedRoyalBlue);
            _wags[30] = new LargeGadget(FinishColor.PaintedGreen);
            _wags[31] = new LargeGadget(FinishColor.PaintedChiefsRed);
            _wags[32] = new LargeGadget(FinishColor.PaintedPink);
            _wags[33] = new LargeGadget(FinishColor.PaintedYellow);
            _wags[34] = new LargeGadget(FinishColor.PlatedRoseGold);
            _wags[35] = new LargeGadget(FinishColor.PlatedSilver);
            _wags[36] = new LargeGadget(FinishColor.PlatedGold);
            _wags[37] = new LargeGadget(FinishColor.PlatedRhodium);
            _wags[38] = new LargeGadget(FinishColor.PlatedPlatinum);
            _wags[39] = new LargeGadget(FinishColor.PlatedCamouflage);
            _wags[40] = new LargeGadget(FinishColor.PlainWhite);
            _wags[41] = new LargeGadget(FinishColor.PlainGray);
            _wags[42] = new LargeGadget(FinishColor.PlainBlack);
        }

        public virtual IEnumerator<IWag> GetEnumerator()
        {
            return ((IEnumerable<IWag>)_wags).GetEnumerator();
        }
    }
}
