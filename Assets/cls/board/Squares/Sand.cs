using Assets.cls;
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.18034
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
using System;
using System.Collections.Generic;
using UnityEngine;


namespace AssemblyCSharp
{
    public class Sand : ISquareDiv
    {


        protected Dictionary<int, Sprite> StateList;
        private int State;
        private Sprite _image;
        public Sand()
        {
            Init();
        }
        public Sand(int state)
        {
            Init();
            InitState(state);
        }
        private void Init()
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

            //StateList.Add(0, StaticSpriteCache.sprites[22]);
            StateList.Add(0, StaticSpriteCache.sprites[84]);
        }
        public int IncrementDamage { get; set; }
        public bool UpdateBase(int elapsedTime, int damage)
        {
            IncrementDamage = IncrementDamage + damage;
            //тут реализовываетс ялогика, разрушения. каждый разрушшаемый блок, разрушается по разному в зависимости от Damage(кирка, взрыв)
            //switch (IncrementDamage)
            //{
            //    //DoDamage сразу меняет картинку квадрата. после скольки то ударов.
            //    case (>= 2):// ERROR: Case labels with binary operators are unsupported : GreaterThanOrEqual
                    
            //        this.State = this.State + 1;
            //        return true;
            //    //Case 9, 18, 27
            //    //    DoDamage(0, 1)
            //}
            if (IncrementDamage >=2)
            {
                this.State = this.State + 1;
                return true;

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
    public class Sand2 : Sand
    {
        public override void SetUpImages()
        {
            //StateList.Add(0, StaticSpriteCache.sprites[23]);
            StateList.Add(0, StaticSpriteCache.sprites[80]);
        }

    }
    public class Sand3 : Sand
    {
        public override void SetUpImages()
        {
            //StateList.Add(0, StaticSpriteCache.sprites[24]);
            StateList.Add(0, StaticSpriteCache.sprites[85]);
        }

    }
}

