using Assets.cls;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AssemblyCSharp.Assets.cls.board.pupi
{
    public class PileOfCoins : PUPI
    {

        public override void AbsorbAction()
        {
            //player.AddStatGoldTaken(15);
        }
        public override void PlaceMe()
        {
            //base.Image.SetValue(Image.SourceProperty, ResCache.PUPI(13, 7));
            AssignedSprite = StaticSpriteCache.sprites[99];
        }
        public override string Name()
        {
            return "PileOfCoins";
        }

    }
}
