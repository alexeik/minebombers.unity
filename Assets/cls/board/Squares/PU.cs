﻿using Assets.cls;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using UnityEngine;

namespace AssemblyCSharp
{
    public class PU : ISquareDiv
    {


        protected Dictionary<int, Sprite> StateList;
        private int State;
        private Sprite _image;
        public PU()
        {
            Init();
        }
        public PU(int state)
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
           // StateList.Add(0, StaticSpriteCache.sprites[9]);
            StateList.Add(0, StaticSpriteCache.sprites[67]);
        }
        public int IncrementDamage { get; set; }
        public bool UpdateBase(int elapsedTime, int damage)
        {
            IncrementDamage = IncrementDamage + damage;
            //тут реализовываетс ялогика, разрушения. каждый разрушшаемый блок, разрушается по разному в зависимости от Damage(кирка, взрыв)
            if (IncrementDamage > 2)
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
}
