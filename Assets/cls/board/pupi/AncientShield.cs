using Assets.cls;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AssemblyCSharp.Assets.cls.board.pupi
{
    public class AncientShield : PUPI
    {

        public override void AbsorbAction()
        {
            //player.UiConnector.AxeCount = player.UiConnector.AxeCount + 10
        }
        public override void PlaceMe()
        {
            //base.Image.SetValue(Image.SourceProperty, ResCache.PUPI(12, 9));
            AssignedSprite = StaticSpriteCache.sprites[86];
        }
        public override string Name()
        {
            return "AncientShield";
        }


    }
}
