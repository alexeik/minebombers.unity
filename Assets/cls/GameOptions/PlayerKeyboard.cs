using Assets.cls.Player;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using UnityEngine;

namespace Assets.cls.GameOptions
{
    public class PlayerKeyboard
    {
        public Dictionary<PlayerInputActions, KeyCode> KeyList;
        public PlayerBody Owner { get; set; }
        public int Layout { get; set; }
        public PlayerKeyboard(PlayerBody pb)
        {
            Owner = pb;
            switch (pb.Num)
            {
                case 1:
                    InitLayout1();
                    break;
                case 2:
                    InitLayout2();
                    break;
            }

        }
        public void InitLayout1()
        {
            Layout = 1;
            KeyList = new Dictionary<PlayerInputActions, KeyCode>();
            KeyList.Add(PlayerInputActions.Buy, KeyCode.C);
            KeyList.Add(PlayerInputActions.ChangeItem, KeyCode.C);
            KeyList.Add(PlayerInputActions.MoveDown, KeyCode.S);
            KeyList.Add(PlayerInputActions.MoveLeft, KeyCode.A);
            KeyList.Add(PlayerInputActions.MoveRight, KeyCode.D);
            KeyList.Add(PlayerInputActions.MoveTop, KeyCode.W);
            KeyList.Add(PlayerInputActions.Sell, KeyCode.V);
            KeyList.Add(PlayerInputActions.UseItem, KeyCode.V);
            KeyList.Add(PlayerInputActions.UseRemote, KeyCode.B);
            KeyList.Add(PlayerInputActions.MoveStop, KeyCode.Q);
            KeyList.Add(PlayerInputActions.Special, KeyCode.E);
        }
        public void InitLayout2()
        {
            Layout = 2;
            KeyList = new Dictionary<PlayerInputActions, KeyCode>();
            KeyList.Add(PlayerInputActions.Buy, KeyCode.Alpha1);
            KeyList.Add(PlayerInputActions.ChangeItem, KeyCode.Keypad1);
            KeyList.Add(PlayerInputActions.MoveDown, KeyCode.DownArrow);
            KeyList.Add(PlayerInputActions.MoveLeft, KeyCode.LeftArrow);
            KeyList.Add(PlayerInputActions.MoveRight, KeyCode.RightArrow);
            KeyList.Add(PlayerInputActions.MoveTop, KeyCode.UpArrow);
            KeyList.Add(PlayerInputActions.Sell, KeyCode.Keypad2);
            KeyList.Add(PlayerInputActions.UseItem, KeyCode.Keypad2);
            KeyList.Add(PlayerInputActions.UseRemote, KeyCode.Keypad3);
            KeyList.Add(PlayerInputActions.MoveStop, KeyCode.Keypad4);
            KeyList.Add(PlayerInputActions.Special, KeyCode.Keypad5);
        }
    }
    public enum PlayerInputActions
    {
        MoveLeft = 1,
        MoveRight = 2,
        MoveTop = 3,
        MoveDown = 4,
        Buy = 5,
        Sell = 6,
        UseRemote = 7,
        UseItem = 8,
        ChangeItem = 9,
        MoveStop = 10,
        Special = 11
    }

}
