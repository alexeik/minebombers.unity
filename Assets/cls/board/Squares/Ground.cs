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
using UnityEngine;
using Assets.cls;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;

namespace AssemblyCSharp
{

	public class Ground : ISquareDiv
	{
		
		
		
		
		
		private Dictionary<int, Sprite> StateList;
		private int State;
		private Sprite _image;
		//Private ItemsDamageList As Dictionary(Of Integer,
		public Ground()
		{
			Init();

		}
		public Ground(int state)
		{
			Init();
			InitState(state);
		}
		private void Init()
		{

			_image = null;


			LoadMe();
		}
		public bool IsPassable()
		{
			return true;
		}
		//самый нижний слой, земля. только по ней может ходить человечек.
		public void LoadMe()
		{
			//  Dim uri As Uri, imgsrc As ImageSource
			StateList = new Dictionary<int, Sprite>();
			// uri = New Uri("images/map/mb_ground.png", UriKind.Relative)
			//imgsrc =
            //Sprite sp = StaticSpriteCache.sprites[8];
            Sprite sp = StaticSpriteCache.sprites[65];
			StateList.Add(0,sp );
			State = 0;
			UpdateImage();
		}
		private void UpdateImage()
		{
			_image =Base;
		}
		public Sprite Base {
			get { return StateList[State]; }
		}
		
		public bool UpdateBase(int elapsedTime, int damage)
		{
			//Me.State = damage
			return false;
		}
		
		public Sprite Image {
			get { return _image; }
		}
		public bool YouMustRemoveMe()
		{
			return false;
		}
		public bool YouMustUpdateMe()
		{
			return false;
		}
		public bool CanBeDamaged()
		{
			return false;
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

