using Assets.cls;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AssemblyCSharp.Assets.cls.board.pupi
{
    public class Rubin : PUPI
    {

        public override void AbsorbAction()
        {
            //player.AddStatGoldTaken(65);
        }
        public override void PlaceMe()
        {
            //base.Image.SetValue(Image.SourceProperty, ResCache.PUPI(13, 4));
            AssignedSprite = StaticSpriteCache.sprites[101];

        }
        public override string Name()
        {
            return "Rubin";
        }


    }
}
