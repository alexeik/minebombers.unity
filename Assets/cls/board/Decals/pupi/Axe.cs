using AssemblyCSharp;
using Assets.cls;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AssemblyCSharp
{


    public class Axe : PUPI
    {


        public override void AbsorbAction()
        {
            //player.CreatePlayerSeat.AxeCount = player.CreatePlayerSeat.AxeCount + 1;
        }
        public override void PlaceMe()
        {
            //base.Image.SetValue(Image.SourceProperty, ResCache.PUPI(10, 0));
            AssignedSprite = StaticSpriteCache.sprites[88];
        }

        public override string Name()
        {
            return "Axe";
        }

 
    }

}
