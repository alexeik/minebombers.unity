using Assets.cls;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using UnityEngine;

namespace AssemblyCSharp
{
    public class Rock : ISquareDiv
    {


        protected Dictionary<int, Sprite> StateList;
        private int State;
        private Sprite _image;
        public Rock()
        {
            Init();
        }
        public Rock(int state)
        {
            Init();
            InitState(state);
        }
        protected void Init()
        {
            _image = null;
            LoadMe();
        }
        public Sprite Base
        {
            get { return StateList[State]; }
        }

        public bool CanBeDamaged()
        {
            return true;
        }

        public Sprite Image
        {
            get { return _image; }
        }

        public bool IsPassable()
        {
            return false;
        }

        public void LoadMe()
        {
            StateList = new Dictionary<int, Sprite>();
            SetUpImages();
            State = 0;

        }
        public virtual void SetUpImages()
        {
            StateList.Add(0, StaticSpriteCache.sprites[10]);
            StateList.Add(1, StaticSpriteCache.sprites[19]);
            StateList.Add(2, StaticSpriteCache.sprites[18]);
        }
        public int IncrementDamage { get; set; }
        public virtual bool UpdateBase(int elapsedTime, int damage)
        {
            IncrementDamage = IncrementDamage + damage;
            //тут реализовываетс ялогика, разрушения. каждый разрушшаемый блок, разрушается по разному в зависимости от Damage(кирка, взрыв)
            // каждый ущерб должен быть нанесен и картинка изменена. потом ущерб сброшен вн оль. потом нужно еще нанести ущерб,чтобы изменить картинку.
            switch (IncrementDamage)
            {
                //DoDamage сразу меняет картинку квадрата. после скольки то ударов.
                case 9:
                case 10:
                case 11:
                case 12:
                case 13:
                case 14:
                case 15:
                case 16:
                case 17:
                    this.State = this.State + 1;
                    IncrementDamage = 0;
                
                    return true;
                case 18:
                case 19:
                case 20:
                case 21:
                case 22:
                case 23:
                case 24:
                case 25:
                case 26:
                    this.State = this.State + 1;
                    IncrementDamage = 0;
                  
                    return true;
                
                 default: 
                if (IncrementDamage> 26)
                    {
                    this.State = this.State + 1;
                    IncrementDamage = 0;
                    return true;
                    
                }
                break;
            }
            return false;
        }

        public bool YouMustRemoveMe()
        {
            if (this.State == StateList.Count)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool YouMustUpdateMe()
        {
            return true;
        }

        public bool CanShowDamage()
        {
            return true;
        }

        public void InitState(int state)
        {
            this.State = state;
        }
    }
    public class Rock2 : Rock
    {
        public Rock2()
            : base()
        {
        }
        public Rock2(int state)
        {
            Init();
            InitState(state);
        }
        public override void SetUpImages()
        {
			StateList.Add(0,StaticSpriteCache.sprites[11]);
			StateList.Add(1,StaticSpriteCache.sprites[19] );
			StateList.Add(2,StaticSpriteCache.sprites[18] );
        }
    }
    public class Rock3 : Rock
    {
        public Rock3()
            : base()
        {
        }
        public Rock3(int state)
        {
            Init();
            InitState(state);
        }
        public override void SetUpImages()
        {
			StateList.Add(0,StaticSpriteCache.sprites[12] );
			StateList.Add(1,StaticSpriteCache.sprites[19] );
			StateList.Add(2, StaticSpriteCache.sprites[18]);
        }
    }
    public class Rock4 : Rock
    {
        public Rock4()
            : base()
        {
        }
        public Rock4(int state)
        {
            Init();
            InitState(state);
        }
        public override void SetUpImages()
        {
			StateList.Add(0,StaticSpriteCache.sprites[13] );
			StateList.Add(1,StaticSpriteCache.sprites[19] );
			StateList.Add(2,StaticSpriteCache.sprites[18]);
        }
    }
    public class Rock5 : Rock
    {
        public Rock5()
            : base()
        {
        }
        public Rock5(int state)
        {
            Init();
            InitState(state);
        }
        public override void SetUpImages()
        {
			StateList.Add(0,StaticSpriteCache.sprites[14] );
			StateList.Add(1,StaticSpriteCache.sprites[19] );
			StateList.Add(2,StaticSpriteCache.sprites[18] );
        }
    }
    public class Rock6 : Rock
    {
        public Rock6()
            : base()
        {
        }
        public Rock6(int state)
        {
            Init();
            InitState(state);
        }
        public override void SetUpImages()
        {
			StateList.Add(0,StaticSpriteCache.sprites[15]);
			StateList.Add(1,StaticSpriteCache.sprites[19]);
			StateList.Add(2,StaticSpriteCache.sprites[18]);
        }

    }
    public class Rock7 : Rock
    {
        public Rock7()
            : base()
        {
        }
        public Rock7(int state)
        {
            Init();
            InitState(state);
        }
        public override void SetUpImages()
        {
			StateList.Add(0,StaticSpriteCache.sprites[16]);
			StateList.Add(1,StaticSpriteCache.sprites[19]);
			StateList.Add(2,StaticSpriteCache.sprites[18]);
        }
    }
    public class Rock8 : Rock
    {
        public Rock8()
            : base()
        {
        }
        public Rock8(int state)
        {
            Init();
            InitState(state);
        }
        public override void SetUpImages()
        {
			StateList.Add(0,StaticSpriteCache.sprites[17]);
			StateList.Add(1,StaticSpriteCache.sprites[19]);
			StateList.Add(2,StaticSpriteCache.sprites[18]);
        }

    }
    public class Rock9 : Rock
    {
        public Rock9()
            : base()
        {
        }
        public Rock9(int state)
        {
            Init();
            InitState(state);
        }
        public override void SetUpImages()
        {
			StateList.Add(0,StaticSpriteCache.sprites[20]);
        }


    }
    public class Rock10 : Rock
    {
        public Rock10()
            : base()
        {
        }
        public Rock10(int state)
        {
            Init();
            InitState(state);
        }
        public override void SetUpImages()
        {
			StateList.Add(0,StaticSpriteCache.sprites[21]);
        }

    }
    public class Rock11 : Rock
    {
        public Rock11()
            : base()
        {
        }
        public Rock11(int state)
        {
            Init();
            InitState(state);
        }
        public override void SetUpImages()
        {
			StateList.Add(0,StaticSpriteCache.sprites[19]);
        }

    }
    public class Rock12 : Rock
    {
        public Rock12()
            : base()
        {
        }
        public Rock12(int state)
        {
            Init();
            InitState(state);
        }
        public override void SetUpImages()
        {
			StateList.Add(0,StaticSpriteCache.sprites[18]);
        }

    }
}
