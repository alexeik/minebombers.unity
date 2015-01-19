using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using UnityEngine;

namespace Assets.cls
{
    static public class StaticSpriteCache
    {
		static public GameObject goCache;
		static public SpritesCache Cache;
        static public Sprite[] sprites = new Sprite[25];
        //static public void LoadCacheFromResources()
        //{

        //    sprites[0] = Resources.Load<UnityEngine.Sprite>("mb_beton");
        //    sprites[1] = Resources.Load<UnityEngine.Sprite>("mb_178");
        //    sprites[2] = Resources.Load<UnityEngine.Sprite>("mb_179");
        //    sprites[3] = Resources.Load<UnityEngine.Sprite>("mb_180");
        //    sprites[4] = Resources.Load<UnityEngine.Sprite>("grid");
        //    sprites[5] = Resources.Load<UnityEngine.Sprite>("bioslime");
        //    sprites[6] = Resources.Load<UnityEngine.Sprite>("key");
        //    sprites[7] = Resources.Load<UnityEngine.Sprite>("mb_ground");
        //    sprites[8] = Resources.Load<UnityEngine.Sprite>("pu");
        //    sprites[9] = Resources.Load<UnityEngine.Sprite>("rock1");
        //    sprites[10] = Resources.Load<UnityEngine.Sprite>("rock10");
        //    sprites[11] = Resources.Load<UnityEngine.Sprite>("rock9");
        //    sprites[12] = Resources.Load<UnityEngine.Sprite>("sand");
        //    sprites[13] = Resources.Load<UnityEngine.Sprite>("sand2");
        //    sprites[14] = Resources.Load<UnityEngine.Sprite>("sand3");


        //}
		static public void LinkTogoSpritesCache()
		{
            //из компонента достаем переменную с массиво спрайтов и оставляем ссылку на этот объект в этом классе StaticSpriteCache
			goCache = GameObject.Find ("goSpritesCache");
			Cache = (SpritesCache)goCache.GetComponent (typeof(SpritesCache));
			sprites = Cache.Sprites;
		}
    }
}
