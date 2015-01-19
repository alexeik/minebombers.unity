using Assets.cls;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AssemblyCSharp.Assets.cls.board.pupi
{
    public class GoldenCross : PUPI
    {

        public override void AbsorbAction()
        {
            //player.AddStatGoldTaken(35);
        }
        public override void PlaceMe()
        {
            //base.Image.SetValue(Image.SourceProperty, ResCache.PUPI(13, 2));
            AssignedSprite = StaticSpriteCache.sprites[97];
        }
        public override string Name()
        {
            return "GoldenCross";
        }

    }
}
