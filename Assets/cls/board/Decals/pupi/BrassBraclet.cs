using Assets.cls;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AssemblyCSharp.Assets.cls.board.pupi
{
    public class BrassBraclet : PUPI
    {

        public override void AbsorbAction()
        {
            //DONE: тут добавить player.AddStatGoldTaken(value) для каждого золота. Количество золота посмотреть в оригинале.
            //player.AddStatGoldTaken(10);
        }
        public override void PlaceMe()
        {
            //base.Image.SetValue(Image.SourceProperty, ResCache.PUPI(12, 10));
            AssignedSprite = StaticSpriteCache.sprites[92];
        }
        public override string Name()
        {
            return "BrassBraclet";
        }


    }
}
