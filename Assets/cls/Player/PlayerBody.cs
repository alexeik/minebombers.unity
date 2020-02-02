using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using UnityEngine;

namespace Assets.cls.Player
{

    public class PlayerBody
    {
        public GameObject Prefab;
        public int Num; //порядковый номер игрока
        //этот метод похоже уйдет в PlayerBehaviours  хотя этот класс и должен стать DefaultPlayerBehaviour
        internal void InsertSoul(PlayerSoul playerSoul)
        {
            throw new NotImplementedException();
        }
    }
}
