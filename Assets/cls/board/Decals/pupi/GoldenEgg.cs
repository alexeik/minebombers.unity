using Assets.cls;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AssemblyCSharp.Assets.cls.board.pupi
{
    public class GoldenEgg : PUPI
    {

        public override void AbsorbAction()
        {
            //player.AddStatGoldTaken(25);
        }
        public override void PlaceMe()
        {
            //base.Image.SetValue(Image.SourceProperty, ResCache.PUPI(13, 3));
            AssignedSprite = StaticSpriteCache.sprites[98];
        }
        public override string Name()
        {
            return "GoldenEgg";
        }


    }
}
