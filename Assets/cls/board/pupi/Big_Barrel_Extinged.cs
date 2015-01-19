using Assets.cls;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AssemblyCSharp.Assets.cls.board.pupi
{
    public class Big_Barrel_Extinged : PUPI
    {

        public override void AbsorbAction()
        {
            //player.UiConnector.AxeCount = player.UiConnector.AxeCount + 10
            //player.AddToBag(new sCrackerBarrel());

            //player.UiConnector.Bag.ReInitialize()
        }
        public override void PlaceMe()
        {
            //base.Image.SetValue(Image.SourceProperty, ResCache.PUPI(22, 3));
            AssignedSprite = StaticSpriteCache.sprites[90];
        }
        public override string Name()
        {
            return "Big_Barrel_Extinged";
        }

    }
}
