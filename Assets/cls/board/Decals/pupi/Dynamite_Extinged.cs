using Assets.cls;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AssemblyCSharp.Assets.cls.board.pupi
{
    public class Dynamite_Extinged : PUPI
    {

        public override void AbsorbAction()
        {
            //player.UiConnector.AxeCount = player.UiConnector.AxeCount + 10
            //player.AddToBag(new sDynamite());

            //player.UiConnector.Bag.ReInitialize()
        }
        public override void PlaceMe()
        {
            //base.Image.SetValue(Image.SourceProperty, ResCache.PUPI(22, 5));
            AssignedSprite = StaticSpriteCache.sprites[94];
        }
        public override string Name()
        {
            return "Dynamite_Extinged";
        }

    }

}
