using Assets.cls;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AssemblyCSharp.Assets.cls.board.pupi
{

    public class ArmorBox : PUPI
    {

        public override void AbsorbAction()
        {

            //player.AddToBag(new sDiggerBomb());
            //player.AddToBag(new sCrucifixBomb());

        }
        public override void PlaceMe()
        {
            //base.Image.SetValue(Image.SourceProperty, ResCache.PUPI(10, 1));
            AssignedSprite = StaticSpriteCache.sprites[87];
        }
        public override string Name()
        {
            return "ArmorBox";
        }

    }
}
