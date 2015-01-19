using Assets.cls;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AssemblyCSharp.Assets.cls.board.pupi
{
    public class Barrel : PUPI
    {

        public override void AbsorbAction()
        {
            //player.UiConnector.AxeCount = player.UiConnector.AxeCount + 10
        }
        public override void PlaceMe()
        {
            //base.Image.SetValue(Image.SourceProperty, ResCache.PUPI(16, 10));
            AssignedSprite = StaticSpriteCache.sprites[61];
        }
        public override string Name()
        {
            return "Barrel";
        }


        public override bool YouMustRemoveMe()
        {
            return false;
        }

    }
}
