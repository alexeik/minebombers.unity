using Assets.cls;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AssemblyCSharp.Assets.cls.board.pupi
{
    public class AxeBig : PUPI
    {

        public override void AbsorbAction()
        {
            //player.CreatePlayerSeat.AxeCount = player.CreatePlayerSeat.AxeCount + 3;
        }
        public override void PlaceMe()
        {
            //base.Image.SetValue(Image.SourceProperty, ResCache.PUPI(10, 2));
            AssignedSprite = StaticSpriteCache.sprites[89];

        }
        public override string Name()
        {
            return "AxeBig";
        }


    }
}
