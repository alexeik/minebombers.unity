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
namespace AssemblyCSharp
{
		public static class GameController
		{
		public const uint MaxY   = 630;
		public const uint MaxX   = 630;
		public const uint MaxYInt   = MaxY / 10;
		public const uint MaxXInt = MaxX / 10;
		public static Square[,] board = new Square[MaxXInt + 1, MaxYInt + 1];
		public static IDecal[,] DecalLayer = new IDecal[MaxXInt + 1, MaxYInt + 1];
		public const uint MinY = 10;
		public const uint MinX = 10;
		public const uint MinYInt = MinY / 10;
		public const uint MinXInt = MinX / 10;

	
		public static void SendInfo(EnumMyAction tag)
		{
			switch (tag) {
			case EnumMyAction.GameBoardReady:
				MapLoader ml=new MapLoader();
				ml.Setup();
				ml.LoadLogicalLevel();
				ml.LoadVisualLevel();
				break;
						}
				}
		}
}
