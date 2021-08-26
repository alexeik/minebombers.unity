using Assets.cls;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AssemblyCSharp.Assets.cls.board.pupi
{
    public class Small_Shell_Extinged : PUPI
    {

        public override void AbsorbAction()
        {
            //player.UiConnector.AxeCount = player.UiConnector.AxeCount + 10
            //player.AddToBag(new sSmallShell());
            //DONE: сделать трансформацию этих PUPI в бомбы, когда они подрываются другим, или нен адо? пусть только можно собрать, ане подрывать. это вроде лучше.
            //player.UiConnector.Bag.ReInitialize()
        }
        public override void PlaceMe()
        {
            //base.Image.SetValue(Image.SourceProperty, ResCache.PUPI(22, 6));
            AssignedSprite = StaticSpriteCache.sprites[104];
        }
        public override string Name()
        {
            return "Small_Shell_Extinged";
        }

    }
}
