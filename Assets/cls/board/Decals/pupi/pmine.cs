using Assets.cls;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AssemblyCSharp.Assets.cls.board.pupi
{
    public class pMine : PUPI
    {
        //private PlayerBody p;
        public override void AbsorbAction()
        {
            //if (Owner.Num == player.Num)
            //{
            //    @remove = false;
            //    return;
            //}
            //p = player;
            //TransformTo(0);
            //@remove = true;
        }
        private bool @remove;
        public override void PlaceMe()
        {
            //base.Image.SetValue(Image.SourceProperty, ResCache.PUPI(19, 0));
            AssignedSprite = StaticSpriteCache.sprites[88];

        }
        public override string Name()
        {
            return "Mine";
        }


        public override bool YouMustRemoveMe()
        {
            return @remove;
        }
        public override void TransformTo(int damage)
        {
            //Bomb b = default(Bomb);
            //b = new Mine();
            //b.AddIBody(p);
            ////запуск работы бомбы - инициализация
            //b.Tick();
            //// размещение бомбы на поле
            //PoleG.Children.Add(b.Visual);
            //Canvas.SetZIndex(b.Visual, 1);
            ////внесение в коллекцию ,которая автоматически тактируется 
            //PendingItemCollection.Add(b);
        }
    }
}
