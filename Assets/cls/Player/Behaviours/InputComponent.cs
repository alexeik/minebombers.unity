using AssemblyCSharp;
using Assets.cls.GameOptions;
using Assets.cls.Player.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;

namespace Assets.cls.Player.Behaviours
{
    public class InputComponent
    {
        public void Update(DefaultPlayerBehaviour player)
        {
                if (Input.anyKey)
            {
                if (Input.GetKey(GameController.GO.PK1.KeyList[PlayerInputActions.Special]))
                {
                    GameController.PlayerHUDs[1].CloneMode = !GameController.PlayerHUDs[1].CloneMode;
                }
                if (Input.GetKey(GameController.GO.PK2.KeyList[PlayerInputActions.Special]))
                {
                    GameController.PlayerHUDs[2].CloneMode = !GameController.PlayerHUDs[2].CloneMode;
                }







                if (Input.GetKey(GameController.GO.PK1.KeyList[PlayerInputActions.ChangeItem]))
                {
                    if (GameController.PlayerHUDs[1].CloneMode & GameController.PlayerHUDs[1].CanUseClone)
                    {
                        //тут пустота, так как для клона нельзя юзать рюкзак
                    }
                    else
                    {
                        GameController.PlayerHUDs[1].NextItem();
                    }

                }
                else if (Input.GetKey(GameController.GO.PK1.KeyList[PlayerInputActions.MoveDown]))
                {
                    if (GameController.PlayerHUDs[1].CloneMode & GameController.PlayerHUDs[1].CanUseClone)
                    {
                        player.InsertSoul(new PlayerSoul(1, MoveDirection.Down));

                    }
                    else
                    {
                        player.InsertSoul(new PlayerSoul(1, MoveDirection.Down));
                    }



                }

                else if (Input.GetKey(GameController.GO.PK1.KeyList[PlayerInputActions.MoveLeft]))
                {
                    if (GameController.PlayerHUDs[1].CloneMode & GameController.PlayerHUDs[1].CanUseClone)
                    {
                        //тут пустота, так как для клона нельзя юзать рюкзак

                        player.InsertSoul(new PlayerSoul(1, MoveDirection.Left));

                    }
                    else
                    {
                        player.InsertSoul(new PlayerSoul(1, MoveDirection.Left));
                    }

                }

                else if (Input.GetKey(GameController.GO.PK1.KeyList[PlayerInputActions.MoveRight]))
                {
                    if (GameController.PlayerHUDs[1].CloneMode & GameController.PlayerHUDs[1].CanUseClone)
                    {
                        //тут пустота, так как для клона нельзя юзать рюкзак
                        player.InsertSoul(new PlayerSoul(1, MoveDirection.Right));
                    }
                    else
                    {
                        player.InsertSoul(new PlayerSoul(1, MoveDirection.Right));
                    }

                }

                else if (Input.GetKey(GameController.GO.PK1.KeyList[PlayerInputActions.MoveTop]))
                {

                    if (GameController.PlayerHUDs[1].CloneMode & GameController.PlayerHUDs[1].CanUseClone)
                    {
                        //тут пустота, так как для клона нельзя юзать рюкзак
                        player.InsertSoul(new PlayerSoul(1,  MoveDirection.Top));
                    }
                    else
                    {
                        player.InsertSoul(new PlayerSoul(1,  MoveDirection.Top));
                    }

                }

                else if (Input.GetKey(GameController.GO.PK1.KeyList[PlayerInputActions.UseItem]))
                {
                    if (GameController.PlayerHUDs[1].CloneMode & GameController.PlayerHUDs[1].CanUseClone)
                    {
                        //тут пустота, так как для клона нельзя юзать рюкзак
                    }
                    else
                    {
                        GameController.PlayerHUDs[1].UseItem();
                    }

                }
                else if (Input.GetKey(GameController.GO.PK1.KeyList[PlayerInputActions.UseRemote]))
                {
                    if (GameController.PlayerHUDs[1].CloneMode & GameController.PlayerHUDs[1].CanUseClone)
                    {
                        //тут пустота, так как для клона нельзя юзать рюкзак
                    }
                    else
                    {
                        GameController.PlayerHUDs[1].UseRemoteItem();
                    }

                }

                else if (Input.GetKey(GameController.GO.PK1.KeyList[PlayerInputActions.MoveStop]))
                {

                    if (GameController.PlayerHUDs[1].CloneMode & GameController.PlayerHUDs[1].CanUseClone)
                    {
                        //тут пустота, так как для клона нельзя юзать рюкзак
                        player.InsertSoul(new PlayerSoul(1, MoveDirection.None));
                    }
                    else
                    {
                        player.InsertSoul(new PlayerSoul(1, MoveDirection.None));
                    }

                }

                else if (Input.GetKey(GameController.GO.PK2.KeyList[PlayerInputActions.ChangeItem]))
                {
                    if (GameController.PlayerHUDs[2].CloneMode & GameController.PlayerHUDs[2].CanUseClone)
                    {
                        //тут пустота, так как для клона нельзя юзать рюкзак

                    }
                    else
                    {
                        GameController.PlayerHUDs[2].NextItem();
                    }

                }

                else if (Input.GetKey(GameController.GO.PK2.KeyList[PlayerInputActions.MoveDown]))
                {
                    if (GameController.PlayerHUDs[2].CloneMode & GameController.PlayerHUDs[2].CanUseClone)
                    {
                        //тут пустота, так как для клона нельзя юзать рюкзак
                        player.InsertSoul(new PlayerSoul(1, MoveDirection.Down));
                    }
                    else
                    {
                        player.InsertSoul(new PlayerSoul(1, MoveDirection.Down));
                    }

                }

                else if (Input.GetKey(GameController.GO.PK2.KeyList[PlayerInputActions.MoveLeft]))
                {
                    if (GameController.PlayerHUDs[2].CloneMode & GameController.PlayerHUDs[2].CanUseClone)
                    {
                        //тут пустота, так как для клона нельзя юзать рюкзак
                        player.InsertSoul(new PlayerSoul(1, MoveDirection.Left));
                    }
                    else
                    {
                        player.InsertSoul(new PlayerSoul(1, MoveDirection.Left));
                    }

                }
                else if (Input.GetKey(GameController.GO.PK2.KeyList[PlayerInputActions.MoveRight]))
                {

                    if (GameController.PlayerHUDs[2].CloneMode & GameController.PlayerHUDs[2].CanUseClone)
                    {
                        //тут пустота, так как для клона нельзя юзать рюкзак
                        player.InsertSoul(new PlayerSoul(1,  MoveDirection.Right));
                    }
                    else
                    {
                        player.InsertSoul(new PlayerSoul(1,  MoveDirection.Right));
                    }
                }
                else if (Input.GetKey(GameController.GO.PK2.KeyList[PlayerInputActions.MoveTop]))
                {

                    if (GameController.PlayerHUDs[2].CloneMode & GameController.PlayerHUDs[2].CanUseClone)
                    {
                        //тут пустота, так как для клона нельзя юзать рюкзак
                        player.InsertSoul(new PlayerSoul(1,  MoveDirection.Top));
                    }
                    else
                    {
                        player.InsertSoul(new PlayerSoul(1,  MoveDirection.Top));
                    }

                }
                else if (Input.GetKey(GameController.GO.PK2.KeyList[PlayerInputActions.UseItem]))
                {
                    if (GameController.PlayerHUDs[2].CloneMode & GameController.PlayerHUDs[2].CanUseClone)
                    {
                        //тут пустота, так как для клона нельзя юзать рюкзак

                    }
                    else
                    {
                        GameController.PlayerHUDs[2].UseItem();
                    }

                }
                else if (Input.GetKey(GameController.GO.PK2.KeyList[PlayerInputActions.UseRemote]))
                {
                    if (GameController.PlayerHUDs[2].CloneMode & GameController.PlayerHUDs[2].CanUseClone)
                    {
                        //тут пустота, так как для клона нельзя юзать рюкзак

                    }
                    else
                    {
                        GameController.PlayerHUDs[2].UseRemoteItem();
                    }

                }
                else if (Input.GetKey(GameController.GO.PK2.KeyList[PlayerInputActions.MoveStop]))
                {
                    if (GameController.PlayerHUDs[2].CloneMode & GameController.PlayerHUDs[2].CanUseClone)
                    {
                        //тут пустота, так как для клона нельзя юзать рюкзак
                        player.InsertSoul(new PlayerSoul(1, MoveDirection.None));
                    }
                    else
                    {
                        player.InsertSoul(new PlayerSoul(1, MoveDirection.None));
                    }

                }

            }
        }

    }
}
