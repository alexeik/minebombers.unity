using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using UnityEngine;

namespace Assets.cls.Player
{
   public class PlayerHUD
    {
       public bool CloneMode ;
       public bool CanUseClone;

       internal void NextItem()
       {
           throw new NotImplementedException();
       }
       private GameObject _PlayerBody;
       public GameObject PlayerBody
       {
           get { return _PlayerBody; }
           set { _PlayerBody = value; }
       }
       private GameObject _PlayerClone;
       public GameObject PlayerClone
       {
           get { return _PlayerClone; }
           set { _PlayerClone = value; }
       }

       internal void UseItem()
       {
           throw new NotImplementedException();
       }

       internal void UseRemoteItem()
       {
           throw new NotImplementedException();
       }
    }
}
