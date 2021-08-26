using Assets.cls;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AssemblyCSharp.Assets.cls.board.pupi
{
    public class Teleport : PUPI

    {
        public override void AbsorbAction()
        {
           
        }
        public override void PlaceMe()
        {
            //base.Image.SetValue(Image.SourceProperty, ResCache.PUPI(13, 6));
            AssignedSprite = StaticSpriteCache.sprites[105];
        }
        public override string Name()
        {
            return "Teleport";
        }

        public override bool YouMustRemoveMe()
        {
            return false;
        }
    }
}
