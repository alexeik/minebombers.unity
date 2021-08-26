using Assets.cls;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AssemblyCSharp.Assets.cls.board.pupi
{
    public class Sceptre : PUPI
    {

        public override void AbsorbAction()
        {
            //player.AddStatGoldTaken(50);
        }
        public override void PlaceMe()
        {
            //base.Image.SetValue(Image.SourceProperty, ResCache.PUPI(13, 5));
            AssignedSprite = StaticSpriteCache.sprites[102];
        }
        public override string Name()
        {
            return "Sceptire";
        }


    }

}
