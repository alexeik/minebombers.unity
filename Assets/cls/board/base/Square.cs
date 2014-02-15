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
using Enums;

namespace AssemblyCSharp
{
    public class Square : ISquare
    {
        public string Code;
        public ISquareDiv m_Current;
        private static GameObject _Prefab = null;
		static public Ground GroundCache;
		private WhoIs Who;

        public GameObject Prefab
        {
            get
            {
                return _Prefab;
            }
            set
            {
                _Prefab = value;
            }
        }
		public ISquareDiv Current {
			get { return m_Current; }
			set { m_Current = value; }
		}
        public Stack<ISquareDiv> m_SquareDivCollection;

        public Stack<ISquareDiv> SquareDivCollection
        {
            get { return m_SquareDivCollection; }
            set { m_SquareDivCollection = value; }
        }

        public Square()
        {


            AddGround();
            GetCurrent();

        }

        public Square(ISquareDiv square)
        {


            AddGround();
            m_SquareDivCollection.Push(square);
            GetCurrent();

        }

        private void AddGround()
        {
            m_SquareDivCollection = new Stack<ISquareDiv>();
			m_SquareDivCollection.Push(GroundCache);
        }

        public void AddSquare(ISquareDiv square)
        {
            AddGround();
            m_Current = null;
            m_SquareDivCollection.Push(square);
            GetCurrent();
        }
        /// <summary>
        /// Достаем в m_Current следующий squarediv из стека.
        /// </summary>
        /// <remarks></remarks>
        public void GetCurrent()
        {
            //DoDamage в этом методе m_current может стать nothing.
            if (m_Current == null)
            {
                m_Current = m_SquareDivCollection.Pop();
                Update();

            }
        }

        public void Update()
        {
            if (Prefab == null)
            {
                return;
            }
               
            _Prefab.GetComponent<SpriteRenderer>().sprite = m_Current.Base;
        }
        //public void Update2(GameObject go)
        //{

        //    go.GetComponent<SpriteRenderer>().sprite = m_Current.Base;
        //}
		public void PreUpdateDecals(WhoIs w)
		{
			Who = w;
			UpdateDecals();
		}
		/// <summary>
		/// СОздает декорации вокруг ячейки, по которой был нанесен урон.
		/// </summary>
		/// <remarks></remarks>
		private void UpdateDecals()
		{
			//обновляеми следующую ячейка по ходу движения
			//DONE: сделать роутер для разного направления движения. вообще то не надо. так как это определяется что плеер разрушает.
			int x1 = 0;
			int y1 = 0;
			x1 = (GetX() / 10) + 1;
			y1 = (GetY() / 10);
			UpdateDecalSub(x1, y1, Side.Left, Who);
			x1 = (GetX() / 10) - 1;
			y1 = (GetY() / 10);
			UpdateDecalSub(x1, y1, Side.Right, Who);
			x1 = (GetX() / 10);
			y1 = (GetY() / 10) + 1;
			UpdateDecalSub(x1, y1, Side.Down, Who);
			x1 = (GetX() / 10);
			y1 = (GetY() / 10) - 1;
			UpdateDecalSub(x1, y1, Side.Up, Who);
			
			
		}
		private void UpdateDecalSub(int x1, int y1, Side s, WhoIs w)
		{
			bool f = false;
			//DONE: сделать декорацию для бомб. декорация для бомб сделана только для случаев, когда не происходит разрушения. то есть для начальных случаев.
			//например: когда рядом целый песок или целая скала. если при врзрыве скала меняет состояние, то декорация будет под ней. так как понятно почему.
			//adddamage у объекта бомбы, происходит для всех участвков под бомбой. это происходит слева направ сверх вниз. и так как я тестировал , когда скала разрушалась
			//снизу, то разрушение затирало декорацию.
			
			if (x1 >= GameController.MinXInt & y1 >= GameController.MinYInt & x1 < GameController.MaxXInt & y1 < GameController.MaxYInt) {
				
				if ((GameController.DecalLayer[x1, y1] == null)) {
					if ((GameController.board[x1, y1] == null))
						return;
					
					if (GameController.board[x1, y1].Current is Rock) {
						GameController.DecalLayer[x1, y1] = new SandDecal(x1, y1);
						f = true;
					}
					if (GameController.board[x1, y1].Current is Sand) {
						GameController.DecalLayer[x1, y1] = new SandDecal(x1, y1);
						f = true;
					}
					if (!f)
						return;
				}
				
				if (GameController.board[x1, y1].Current is Rock) {
					f = true;
				}
				
				if (GameController.board[x1, y1].Current is Sand) {
					f = true;
				}
				((IDecal)GameController.DecalLayer[x1, y1]).Update(x1, y1, s, w);
			}
		}
		private void RemoveDecal()
		{
			//убираем декорации с разрушенной ячейки
			int x1 = 0;
			int y1 = 0;
			x1 = (GetX() / 10);
			y1 = (GetY() / 10);
			RemoveDecalSub(x1, y1, Side.Left, Who);
					
		}
		private void RemoveDecalSub(int x1, int y1, Side s, WhoIs w)
		{
			if (x1 >= GameController.MinXInt & y1 >= GameController.MinYInt & x1 <= GameController.MaxXInt & y1 <= GameController.MaxYInt) {
				
				if ((GameController.DecalLayer[x1, y1] == null)) {
				} else {
					((IDecal)GameController.DecalLayer[x1, y1]).Remove(x1, y1, s, w);
					GameController.DecalLayer[x1, y1] = null;
				}
				
			}
		}
		private int GetX()
		{
			return (int)Prefab.transform.position.x;// Canvas.GetLeft(Image);
		}
		private int GetY()
		{
            return (int)Prefab.transform.position.y;//Canvas.GetTop(Image);
		}
    }




}

