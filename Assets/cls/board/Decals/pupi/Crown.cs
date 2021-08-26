using Assets.cls;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AssemblyCSharp.Assets.cls.board.pupi
{
	public class Crown : PUPI
	{

		public override void AbsorbAction()
		{
            //player.AddStatGoldTaken(100);
		}
		public override void PlaceMe()
		{
            //base.Image.SetValue(Image.SourceProperty, ResCache.PUPI(13, 0));
            AssignedSprite = StaticSpriteCache.sprites[93];
		}
		public override string Name()
		{
			return "Crown";
		}


	}
}
