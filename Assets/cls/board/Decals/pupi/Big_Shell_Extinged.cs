using Assets.cls;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AssemblyCSharp.Assets.cls.board.pupi
{
    public class Big_Shell_Extinged : PUPI
    {

        public override void AbsorbAction()
        {
            //player.UiConnector.AxeCount = player.UiConnector.AxeCount + 10
            //player.AddToBag(new sSmallShell());

            //player.UiConnector.Bag.ReInitialize()
        }
        public override void PlaceMe()
        {
            //base.Image.SetValue(Image.SourceProperty, ResCache.PUPI(22, 4));
            AssignedSprite = StaticSpriteCache.sprites[91];
        }
        public override string Name()
        {
            return "Big_Shell_Extinged";
        }

 
    }
}
