using AssemblyCSharp;
using Assets.cls;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AssemblyCSharp
{
    public class MedKit : PUPI
    {


        public override void AbsorbAction()
        {
            //player.CreatePlayerSeat.HP = player.CreatePlayerSeat.HP + 10;
        }

        public override string Name()
        {
            return "MedicalKit";
        }

        public override void PlaceMe()
        {
            //Image.SetValue(Image.SourceProperty, ResCache.PUPI(10, 3));
            AssignedSprite = StaticSpriteCache.sprites[95];
        }


    }

}
