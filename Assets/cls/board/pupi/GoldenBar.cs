using Assets.cls;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AssemblyCSharp.Assets.cls.board.pupi
{
    public class GoldenBar : PUPI
    {

        public override void AbsorbAction()
        {
            //player.AddStatGoldTaken(30);
        }
        public override void PlaceMe()
        {
            //base.Image.SetValue(Image.SourceProperty, ResCache.PUPI(13, 1));
            AssignedSprite = StaticSpriteCache.sprites[96];
        }
        public override string Name()
        {
            return "GoldenBar";
        }


    }
}
