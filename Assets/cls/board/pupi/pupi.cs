using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using UnityEngine;

namespace AssemblyCSharp
{
    public abstract class PUPI 
    {



        public int State;
        private int X;
        private int Y;

        private GameObject _Prefab;

        public GameObject Prefab
        {
            get { return _Prefab; }
            set { _Prefab = value; }
        }
        public Sprite AssignedSprite;

        private bool absd = false;
        public uint Count { get; set; }
   
        public bool IsAbsorbed()
        {
            return absd;
        }

        public PUPI(int x, int y)
        {
            this.X = x;
            this.Y = y;
            Init();
            //Canvas.SetLeft(Image, x);
            //Canvas.SetTop(Image, y);
            LoadMe();
            PlaceMe();
        }

        public PUPI()
        {
            Init();
            LoadMe();
            PlaceMe();

        }
        public void Init()
        {
            //Image = new Image();
            State = 1;
        }
        public void Update()
        {
            if (_Prefab == null)
            {
                return;
            }

            _Prefab.GetComponent<SpriteRenderer>().sprite =AssignedSprite;
            _Prefab.GetComponent<SpriteRenderer>().sortingLayerID = 1;
        }
        private void LoadMe()
        {
        }
        public abstract void PlaceMe();
        // Image.SetValue(Image.SourceProperty, ResCache.PUPI(10, 3))
        //End Sub

        //public void Absorb(PlayerBody player)
        //{
        //    AbsorbAction(player);
        //    if (YouMustRemoveMe())
        //    {
        //        absd = true;

        //        PoleG.Children.Remove(Image);
        //    }
        //    Owner = null;
        //}
        public abstract string Name();
        public virtual bool YouMustRemoveMe()
        {

            return true;
        }

        public virtual bool CanUse()
        {
            return true;
        }

        public abstract void AbsorbAction();
        // player.UiConnector.HP = player.UiConnector.HP + 10
        //End Sub

        //public void AddIBody(IBody ib)
        //{
        //    Owner = ib;
        //    Canvas.SetLeft(Image, Owner.Xsquare * 10);
        //    Canvas.SetTop(Image, Owner.Ysquare * 10);
        //    //WeaponObject.AddIBody(ib)
        //}
        //public PlayerBody Owner { get; set; }

        public virtual void TransformTo(int damage)
        {
        }

       
    }

   
}
