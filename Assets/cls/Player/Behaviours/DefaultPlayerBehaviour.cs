using AssemblyCSharp;
using Assets.cls.GameOptions;
using Assets.cls.Player;
using Assets.cls.Player.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using UnityEngine;

namespace Assets.cls.Behaviours
{
    class DefaultPlayerBehaviour : MonoBehaviour
    {
        
        public float speed = 1f;
        public int Num = 1; //задает порядковый номер игрока.
        private MoveDirection PrevDir;
        private MoveDirection Dir;
        public PlayerSoul NextSoul;
        public PlayerSoul m_MySoul;
        public MoveDirection LookTo;
        public Boolean DirectionChanged;
        private bool m_locked;
        private int Xsquare;
        private int Ysquare;
        private float X;
        private float Y;
        private decimal SpriteH = 0.1M;
        private decimal SpriteW = 0.1M;
        private int Xsquare2;
        private int Ysquare2;
        private int Ysquare1;
        private int Xsquare1;
        private uint MaxX = 630;
        private uint MinY = 0;
        private uint MinX = 0;
        private uint MaxY = 630;
        private Animator animator;
        private bool f = false;
        private MoveDirection m_locked_dir;

        public void Update()
        {



            X = transform.position.x;
            Y = transform.position.y;



            //Quaternion rotation = Quaternion.AngleAxis(10f * Time.deltaTime, new Vector3( 1f, 1f, -0.5f));

            // применение вращения
            //transform.rotation *= rotation;
            //if (!f) {
            //    //transform.RotateAround(new Vector3(transform.position.x+0.1f, transform.position.y, transform.position.z), Vector3.forward, 90);
            //    float angle = Mathf.Atan2(transform.position.y, transform.position.x) * Mathf.Rad2Deg;
            //    transform.rotation = Quaternion.AngleAxis(angle, Vector3.forward);
            //f = true;
            //}
            //return;

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
                    PrevDir = Dir;
                    Dir = MoveDirection.Down;

                    if (GameController.PlayerHUDs[1].CloneMode & GameController.PlayerHUDs[1].CanUseClone)
                    {
                        InsertSoul(new PlayerSoul(1, Dir));

                    }
                    else
                    {
                        InsertSoul(new PlayerSoul(1, Dir));
                    }



                }

                else if (Input.GetKey(GameController.GO.PK1.KeyList[PlayerInputActions.MoveLeft]))
                {
                    PrevDir = Dir;
                    Dir = MoveDirection.Left;
                    if (GameController.PlayerHUDs[1].CloneMode & GameController.PlayerHUDs[1].CanUseClone)
                    {
                        //тут пустота, так как для клона нельзя юзать рюкзак

                        InsertSoul(new PlayerSoul(1, Dir));

                    }
                    else
                    {
                        InsertSoul(new PlayerSoul(1, Dir));
                    }

                }

                else if (Input.GetKey(GameController.GO.PK1.KeyList[PlayerInputActions.MoveRight]))
                {
                    PrevDir = Dir;
                    Dir = MoveDirection.Right;
                    if (GameController.PlayerHUDs[1].CloneMode & GameController.PlayerHUDs[1].CanUseClone)
                    {
                        //тут пустота, так как для клона нельзя юзать рюкзак
                        InsertSoul(new PlayerSoul(1, Dir));
                    }
                    else
                    {
                        InsertSoul(new PlayerSoul(1, Dir));
                    }

                }

                else if (Input.GetKey(GameController.GO.PK1.KeyList[PlayerInputActions.MoveTop]))
                {
                    PrevDir = Dir;
                    Dir = MoveDirection.Top;
                    if (GameController.PlayerHUDs[1].CloneMode & GameController.PlayerHUDs[1].CanUseClone)
                    {
                        //тут пустота, так как для клона нельзя юзать рюкзак
                        InsertSoul(new PlayerSoul(1, Dir));
                    }
                    else
                    {
                        InsertSoul(new PlayerSoul(1, Dir));
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
                    PrevDir = Dir;
                    Dir = MoveDirection.None;
                    if (GameController.PlayerHUDs[1].CloneMode & GameController.PlayerHUDs[1].CanUseClone)
                    {
                        //тут пустота, так как для клона нельзя юзать рюкзак
                        InsertSoul(new PlayerSoul(1, Dir));
                    }
                    else
                    {
                        InsertSoul(new PlayerSoul(1, Dir));
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
                    PrevDir = Dir;
                    Dir = MoveDirection.Down;
                    if (GameController.PlayerHUDs[2].CloneMode & GameController.PlayerHUDs[2].CanUseClone)
                    {
                        //тут пустота, так как для клона нельзя юзать рюкзак
                        InsertSoul(new PlayerSoul(1, Dir));
                    }
                    else
                    {
                        InsertSoul(new PlayerSoul(1, Dir));
                    }

                }

                else if (Input.GetKey(GameController.GO.PK2.KeyList[PlayerInputActions.MoveLeft]))
                {
                    PrevDir = Dir;
                    Dir = MoveDirection.Left;
                    if (GameController.PlayerHUDs[2].CloneMode & GameController.PlayerHUDs[2].CanUseClone)
                    {
                        //тут пустота, так как для клона нельзя юзать рюкзак
                        InsertSoul(new PlayerSoul(1, Dir));
                    }
                    else
                    {
                        InsertSoul(new PlayerSoul(1, Dir));
                    }

                }
                else if (Input.GetKey(GameController.GO.PK2.KeyList[PlayerInputActions.MoveRight]))
                {
                    PrevDir = Dir;
                    Dir = MoveDirection.Right;
                    if (GameController.PlayerHUDs[2].CloneMode & GameController.PlayerHUDs[2].CanUseClone)
                    {
                        //тут пустота, так как для клона нельзя юзать рюкзак
                        InsertSoul(new PlayerSoul(1, Dir));
                    }
                    else
                    {
                        InsertSoul(new PlayerSoul(1, Dir));
                    }
                }
                else if (Input.GetKey(GameController.GO.PK2.KeyList[PlayerInputActions.MoveTop]))
                {
                    PrevDir = Dir;
                    Dir = MoveDirection.Top;
                    if (GameController.PlayerHUDs[2].CloneMode & GameController.PlayerHUDs[2].CanUseClone)
                    {
                        //тут пустота, так как для клона нельзя юзать рюкзак
                        InsertSoul(new PlayerSoul(1, Dir));
                    }
                    else
                    {
                        InsertSoul(new PlayerSoul(1, Dir));
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
                    PrevDir =LookTo ;
                    Dir = MoveDirection.None;
                    if (GameController.PlayerHUDs[2].CloneMode & GameController.PlayerHUDs[2].CanUseClone)
                    {
                        //тут пустота, так как для клона нельзя юзать рюкзак
                        InsertSoul(new PlayerSoul(1, Dir));
                    }
                    else
                    {
                        InsertSoul(new PlayerSoul(1, Dir));
                    }

                }

            }
            if ((NextSoul == null))
            {

            }
            else
            {
                //попробуем протолкнуть следующий soul , если координаты подошли. вернее , это будет поиск, когда вставить следующую команду 
                UpdateNextSoul(NextSoul);
                if ((m_MySoul == null))
                    return;
                seccounter += Time.deltaTime;
                if (seccounter > 0.05)
                {
                    MyActionPrevValue = MyAction;
                    Move(0, m_MySoul.PlayerDirection);
                    MyActionChange(MyAction);
                    seccounter = 0;
                }
                

            }

        }
        public float seccounter;


        public void Start()
        {
           
            animator = this.GetComponent<Animator>();
            
            //animator.SetInteger("MyAction", (int)EnumMyAction.Move);
            //animator.SetFloat("Dir", 0.1f);
            MyActionPrevValue = EnumMyAction.Idle;
            //MyActionChange(EnumMyAction.Idle);

        }

        public void Awake()
        {

        }
        public bool CheckSoul(PlayerSoul s)
        {
            if ((s == null))
                return false;
            if (s.PlayerDirection == MoveDirection.None)
            {
                return false;
            }
            return true;
        }
        /// <summary>
        /// Задача для человечка. Исполняет действие которое пришло сюда. Исполняет если только человек получчает Tick.
        /// done: надо сделать поддержку очереди команд. Проверять каждый тик, есть ли новая душа. Проверять может ли душа применится
        /// с помощью алгоритма CanDoATurn.
        /// </summary>
        /// <param name="s"></param>
        /// <remarks></remarks>
        public void InsertSoul(PlayerSoul s)
        {
            if (!CheckSoul(s))
            {
                s = null;
                NextSoul = null;
                if ((m_MySoul != null))
                {
                    m_MySoul.Deactivate();
                    m_MySoul = null;
                }

                return;
            }

            NextSoul = s;
        }

        public void UpdateNextSoul(PlayerSoul s)
        {

            if (CanDoATurn(s.PlayerDirection))
            {
                //Тут анлочимся. так как нужно обойти ситуацию, когда игрок залочился у бетон и повернул сразу в isPassable=false.  и снимаем топор.
                if ((m_MySoul != null))
                {
                    if (m_MySoul.PlayerDirection != s.PlayerDirection)
                    {
                        UnlockMe(Dir);
                        TakeOffAxe();
                    }
                    else
                    {
                        return;
                        //если направление не изменилось, то просто выходим отсюда, без всяких обновлений души
                    }
                }
                if ((m_MySoul != null))
                {
                    LookTo = m_MySoul.PlayerDirection;
                    m_MySoul.Deactivate();
                    m_MySoul = null;
                }




                m_MySoul = s;

                if (LookTo != m_MySoul.PlayerDirection)
                {
                    DirectionChanged = true;
                }
                else
                {
                    DirectionChanged = false;
                }

                LookTo = m_MySoul.PlayerDirection;
                //Quaternion rotation = Quaternion.AngleAxis(0.1f * Time.deltaTime, new Vector3(0.5f, 0.5f ,1f));
                // MyActionChange(EnumMyAction.Move);
                //// применение вращения
                //transform.rotation *= rotation;
               
            }

        }
        /// <summary>
        /// Алгоритм, не позволяющий поворачивать игроку, на координатах не кратных 5 .  Алгоритм отключен. Видимо, так как Y и X тут беруется, не в момент, нажатия кнопки,
        /// Y и X изменяются каждый Tick.
        /// Похоже, это код надо перемещать, в алгоритм движения. 
        /// </summary>
        /// <param name="dir"></param>
        /// <returns></returns>
        /// <remarks></remarks>
        /// 
        private bool CanDoATurn(MoveDirection dir)
        {
            //чтобы этот алгоритм работал, нужно понимать следующее.
            //коориданат считается в float , но рендер происходит в пиксели. пиксели это целое. 
            //нас интересует две цифры. первый десяток это координата блока верхний угол, а второй разряд это между верхом или низом или между левым и правым.
            //далее мы округляем float координату до 2 разрядов, умножаем на 100 и получаем значение в пикселях. то есть так мы узнаем, на каком реально пикселе стоит картинка.
            //также множится все внутри функции округления, иначе возникают косяки с округлением на таких числах 2.509998f
            //Return True
            int kof = 10;
            decimal f1;
            int d;
            int d2;
            switch (dir)
            {
                case MoveDirection.Left:
                    d = (int)(Math.Ceiling(Math.Round(transform.position.y * 100f, 2, MidpointRounding.AwayFromZero)));

                    if (d % kof == 0)
                    {
                        return true;
                    }
                    break;
                case MoveDirection.Down:

                    decimal f;

                    // d = (int)(Math.Round(transform.position.x * 100f, 2, MidpointRounding.AwayFromZero));
                    d2 = (int)Math.Ceiling((Math.Round(transform.position.x * 100f, 2, MidpointRounding.AwayFromZero)));
                    //f = Convert.ToDecimal(f1) ;
                    //d=Convert.ToInt16( f);

                    if (d2 % kof == 0)
                    {
                        return true;
                    }
                    break;
                case MoveDirection.Right:

                    d = (int)(Math.Ceiling(Math.Round(transform.position.y * 100f, 2, MidpointRounding.AwayFromZero)));

                    if (d % kof == 0)
                    {
                        return true;
                    }
                    break;
                case MoveDirection.Top:

                    d = (int)(Math.Ceiling(Math.Round(transform.position.x * 100f, 2, MidpointRounding.AwayFromZero)));

                    if (d % kof == 0)
                    {
                        return true;
                    }
                    break;
            }
            return false;
        }
        private bool IsLocked()
        {
            return m_locked;
        }

        private void LookUpBoard(MoveDirection dir)
        {
            //определяем прошлую ячейку в этих координатах.
            //поэтому надо поменять xsquare на xsquare1 в bagbody,pupi,ghbody
            //Diagnostics.Debug.WriteLine("DirectionChanged-" & DirectionChanged)
            //тут учитываются смещения по левой верхней точке спрайта. поэтому учитывается смещение этой точки при разных видах движений.

            float kof = 0.01F;

            switch (dir)
            {
                case MoveDirection.Top:
                    Xsquare = Convert.ToInt16(Math.Floor(X * 10f));
                    Ysquare = Convert.ToInt16(Math.Floor((-Y + (float)SpriteH - kof) * 10));
                    break;
                case MoveDirection.Left:
                    Xsquare = Convert.ToInt16(Math.Floor((X + (float)SpriteW - kof) * 10));
                    Ysquare = Convert.ToInt16(Math.Floor(-Y * 10f));
                    break;
                case MoveDirection.Down:
                    Xsquare = Convert.ToInt16(Math.Floor(X * 10f));
                    Ysquare = Convert.ToInt16(Math.Floor((-Y) * 10f));
                    break;
                case MoveDirection.Right:
                    Xsquare = Convert.ToInt16(Math.Floor((X) * 10f));
                    Ysquare = Convert.ToInt16(Math.Floor(-Y * 10f));
                    break;
            }

            //когда игрок осуществляет поворт, то нужно считать по другому. без spritew,h
            //поворот будет определятся на nextsoul
        }
        private void LookUpNextSquare(MoveDirection dir)
        {
            decimal onetenth = 0.01m;

            //ОБНАРУЖИТЬ координаты двух следующих квадратов и только.
            switch (dir)
            {
                case MoveDirection.Top:
                    //выяснить какой квадрат станет следующим, тот который по левой верхней или правой верхней
                    //Xsquare2 = Convert.ToInt16(Math.Floor((Convert.ToDecimal(X) + SpriteW - Convert.ToDecimal(onetenth)) * 10m));
                    //Ysquare2 = Convert.ToInt16(Math.Floor((-Convert.ToDecimal(Y) - Convert.ToDecimal(onetenth)) * 10));


                    Ysquare1 = (int)Math.Floor((-(decimal)Math.Round(transform.position.y, 2) - onetenth) * 10m);
                    Xsquare1 = (int)Math.Floor(((decimal)Math.Round(transform.position.x, 2)) * 10m);

                    break;
                case MoveDirection.Left:
                    //выяснить какой из двух блоков станет следующим,тот который по левой верхней точке или по нижней левой
                    //Xsquare2 = Convert.ToInt16(Math.Floor((Convert.ToDecimal(X) - Convert.ToDecimal(onetenth)) * 10));
                    //Ysquare2 = Convert.ToInt16(Math.Floor((-Convert.ToDecimal(Y) + SpriteH - Convert.ToDecimal(onetenth)) * 10));
                    Xsquare1 = (int)Math.Floor(((decimal)Math.Round(transform.position.x, 2) - onetenth) * 10m);
                    Ysquare1 = (int)Math.Floor((-(decimal)Math.Round(transform.position.y, 2)) * 10m);

                    break;

                case MoveDirection.Down:
                    //выяснить какой квадрат будет следующий, тот который по нижней левой точке или нижней правой точке
                    //Xsquare2 =Convert.ToInt16(  Math.Floor(Convert.ToDecimal(X) * 10m));
                    //Ysquare2 = Convert.ToInt16(Math.Floor((-Convert.ToDecimal(Y) + SpriteH) * 10m));
                    Xsquare1 = (int)Math.Floor(((decimal)Math.Round(transform.position.x, 2) + SpriteW - onetenth) * 10m);
                    Ysquare1 = (int)Math.Floor((-(decimal)Math.Round(transform.position.y, 2) + SpriteH) * 10m);

                    break;
                case MoveDirection.Right:
                    //выяснить какой квадрат будет следующий,тот который по нижней правой точке или по верхней правой точке
                    //Xsquare2 = Convert.ToInt16(Math.Floor((Convert.ToDecimal(X) + SpriteW) * 10m));
                    //Ysquare2 =Convert.ToInt16(  Math.Floor(-Convert.ToDecimal(Y) * 10m));
                    decimal t;
                    t = (decimal)Math.Round(transform.position.x, 2) + SpriteW;
                    Xsquare1 = (int)Math.Floor(t * 10m);
                    t = -(decimal)Math.Round(transform.position.y, 2) + SpriteH - onetenth;
                    Ysquare1 = (int)Math.Floor((t * 10m));
                    break;
            }

        }
        private bool IsNextSquarePassable(int x, int y)

        {
            if (y * 10 <= MaxY & x * 10 <= MaxX & y * 10 >= MinY & x * 10 >= MinX)

            {
                return GameController.board[x, y].IsPassable;
            }
            else
            {
                return false;
            }
        }
        private bool GetTrackItem(int x, int y)
        {
            //пока TrackLayer не введен в unity версии
            //for (int i = 0; i <= TrackLayer.Count - 1; i++)
            //{
            //    if (TrackLayer(i).CheckMyXY(x, y))
            //    {
            //        return true;
            //    }
            //}

            return false;
        }
        private bool IsNextTrackPassable(int Xsquare1, int Ysquare1)
        {
            if (Ysquare1 * 10 <= MaxY & Xsquare1 * 10 <= MaxX & Ysquare1 * 10 >= MinY & Xsquare1 * 10 >= MinX)
            {
                if (GetTrackItem(Xsquare1, Ysquare1))
                {
                    return false;
                }
                else
                {
                    return true;
                }

            }
            return true;
        }
        private bool WeCanMove(MoveDirection dir)
        {
            //проверить если левый не проходим,то возвратить правду
            //проверить если правый не проходим ,то возвратить правду

            //DONE: opt уже не будет так, что человек находится между двух квадратов.

            if (IsNextTrackPassable(Xsquare1, Ysquare1))
            {
                if (!IsNextSquarePassable(Xsquare1, Ysquare1))
                {
                    return false;
                }
                //If Not IsNextSquarePassable(Xsquare2, Ysquare2) Then
                //    Return False
                //End If уже не надо проверять соседнюю клетку.
            }
            else
            {
                return false;
            }


            return true;
        }
        private bool UnlockMe(MoveDirection dir)
        {
            m_locked = false;
            return true;
        }
        public void TakeAxe()
        {
            //MyActionPrevValue = MyAction;
           // MyActionChange(EnumMyAction.Axe);
            MyAction = EnumMyAction.Axe;
        }
        public void TakeOffAxe()
        {
            //MyActionPrevValue = MyAction;
            if (MyAction == EnumMyAction.Axe)
            {

               // MyActionChange(EnumMyAction.Move);
                MyAction = EnumMyAction.Move;
            }
        }
        private void TakeHands()
        {
           // MyActionPrevValue = MyAction;
           // MyActionChange(EnumMyAction.Hands);
            MyAction = EnumMyAction.Hands;
        }
        public void TakeOffHands()
        {
           // MyActionPrevValue = MyAction;
            if (MyAction == EnumMyAction.Hands)
            {

               // MyActionChange(EnumMyAction.Move);
                MyAction = EnumMyAction.Move;
            }
        }
        public void LockMe(MoveDirection dir)
        {
            m_locked_dir = dir;
            m_locked = true;
        }
        public bool IsNextSquareAxeable(int x, int y)
        {
            if (y * 10 <= MaxY & x * 10 <= MaxX & y * 10 >= MinY & x * 10 >= MinX)
            {
                return GameController.board[x, y].m_Current.CanBeDamaged();
            }
            else
            {
                return false;
            }
        }
        public bool WeCanUseAxe()
        {

            if (IsNextSquareAxeable(Xsquare1, Ysquare1) & IsNextTrackPassable(Xsquare1, Ysquare1))
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        private bool WeCanMoveBoulder(MoveDirection todir)
        {
            //пока не работает в unity
            //for (int i = 0; i <= TrackLayer.Count - 1; i++)
            //{
            //    if (TrackLayer(i).CheckMyXY(Xsquare1, Ysquare1))
            //    {
            //        return TrackLayer(i).CanIMoveThere(todir);

            //    }
            //}
            return false;

        }
        private void MoveMe(int len2, MoveDirection dir)
        {

            //if (Input.GetKey(KeyCode.S))
            //{
            //    transform.position -= new Vector3(0.0f, speed * Time.deltaTime, 0.0f);
            //}

            float len = 0.01f;
            MyAction = EnumMyAction.Move;
            switch (dir)
            {
                case MoveDirection.Left:
                    //X = Convert.ToDouble(m_Image.GetValue(Canvas.LeftProperty)) - Convert.ToDouble(len);
                    //m_Image.SetValue(Canvas.LeftProperty, Convert.ToDouble(X));

                    transform.position -= new Vector3(len, 0.0f, 0.0f);

                    break;
                case MoveDirection.Down:
                    //Y = Convert.ToDouble(m_Image.GetValue(Canvas.TopProperty)) + Convert.ToDouble(len);
                    //m_Image.SetValue(Canvas.TopProperty, Convert.ToDouble(Y));
                    transform.position -= new Vector3(0.0f, len, 0.0f);

                    break;
                case MoveDirection.Right:
                    //X = Convert.ToDouble(m_Image.GetValue(Canvas.LeftProperty)) + Convert.ToDouble(len);
                    //m_Image.SetValue(Canvas.LeftProperty, Convert.ToDouble(X));
                    transform.position += new Vector3(len, 0.0f, 0.0f);

                    break;
                case MoveDirection.Top:
                    //Y = Convert.ToDouble(m_Image.GetValue(Canvas.TopProperty)) - Convert.ToDouble(len);
                    //m_Image.SetValue(Canvas.TopProperty, Convert.ToDouble(Y));

                    transform.position += new Vector3(0.0f, len, 0.0f);

                    break;
            }

        }
        /// <summary>
        /// Постоянно двигает иконку игрока. Двигает каждый Tick. Расстояние расчитывается из времени прошедшем от посыла команды до ее исполнения(Tick)
        /// </summary>
        /// <param name="len"></param>
        /// <param name="dir"></param>
        /// <remarks></remarks>
        /// 
        public void DoDamage()
        {
          
            //GameController.board[Xsquare1, Ysquare1].DoIncrementDamage(0, Me.CreatePlayerSeat.AxeCount);
            GameController.board[Xsquare1, Ysquare1].DoIncrementDamage(0, 1);
        }
        public void Move(int len, MoveDirection dir)
        {

            int animationIndex;
            int mNumAnimationFrames = 4;
            animationIndex = ((int)(animator.GetCurrentAnimatorStateInfo(0).normalizedTime * (mNumAnimationFrames))) % mNumAnimationFrames;
            if (animationIndex == 3)
            {
               // Debug.Log("4frame");
                if (MyAction == EnumMyAction.Axe)
                {

                    DoDamage();
                    //  MusicController.PlayByName("axe")

                 }
                if (MyAction == EnumMyAction.Hands)
                {
                    //DoTrackDamage(direction)
                }

            }
            //AbsorbDamage();
            // AbsorbItems();

          
            if (IsLocked())
            {
                LookUpBoard(dir);
                LookUpNextSquare(dir);

                bool bWeCanUseAxe = WeCanUseAxe();
                bool bWeCanMoveBoulder = WeCanMoveBoulder(dir);
                if (WeCanMove(dir))
                {
                    UnlockMe(dir);
                    TakeOffAxe();
                    TakeOffHands();
                    //MyActionChange(MyAction);
                    MoveMe(len, dir);
                    //DONE: косяк. если коснутbся бетона, а после этого сразу коснутся преграды, то преграда не будет разрушаться. так как все зависнет на этом месте.
                    //wecanmove не будет давать переключения,так как преграда ispassable=false. То есть мы подошли. только не взяли топор, как в случае когда подходим к разрушаемому объекту.
                    //то есть когда мы в состоянии locked то уже не проверяется возможность юзания топора.
                    //тут просто. если сменили направление то isLocked можно снять :)
                }
                if (!bWeCanMoveBoulder && !bWeCanUseAxe)
                {
                    TakeOffAxe();
                }
            }
            else
            {
                LookUpBoard(dir);
                LookUpNextSquare(dir);
                bool bWeCanUseAxe = WeCanUseAxe();
                bool bWeCanMoveBoulder = WeCanMoveBoulder(dir);
                if (WeCanMove(dir))
                {
                    //MyActionChange(MyAction);
                    MoveMe(len, dir);
                }
                else
                {
                    LockMe(dir);
                    //если дальше нельзя двигаться, то переходим в состояние замка. проверяем можно ли использовать кирку
                    //если можно, то надеваем кирку, и в следующем цикле рубим.
                    //если мы наткнулись на булыжник, то пытаемся его двигать.
                  
                    if (bWeCanUseAxe)
                    {
                        //этот код убран в UpdateImage, который действует только по 4 кадру анимации.
                        //If MyAction = EnumMyAction.Axe Then
                        //    'делаем, ущерб, когда взяли кирку в руки. а взять мы можем, только сказав TakeAxe подожав обновления и нанести ущерб.
                        //    DoDamage()
                        //End If
                        TakeAxe();
                        //MyActionChange(MyAction);
                        //Diagnostics.Debug.WriteLine("Took Axe")

                    }
            
                    if (bWeCanMoveBoulder)
                    {
                        TakeHands();
                        //MyActionChange(MyAction);
                    }
                    if (!bWeCanMoveBoulder && !bWeCanUseAxe)
                    {
                        TakeOffAxe();
                    }
               
                }

            }
            //MyActionChange(MyAction);
          //  DirectionChanged = false;
            //убираем, флаг о том, что была смена направления
        }
        private EnumMyAction MyAction= EnumMyAction.Idle;
        private EnumMyAction MyActionPrevValue= EnumMyAction.Idle;
        private void MyActionChange(EnumMyAction Newaction)
        {
            if (m_MySoul==null)
            {
                return;
            }
            if (MyAction == MyActionPrevValue && !DirectionChanged)
            {
                return;
            }
            if (MyActionPrevValue != MyAction)
            {
                animator.ResetTrigger(EnumToStringMyAction(MyActionPrevValue));
               // animator.SetTrigger(EnumToStringMyAction(Newaction));

            }

            animator.SetTrigger(EnumToStringMyAction(MyAction));
            animator.SetFloat("MyAction", (float)LookTo);




        }
        public string EnumToStringMyAction(EnumMyAction i)
        {
            switch (i)
            {
                case EnumMyAction.Axe:
                    return "TriggerAxeWork";
                case EnumMyAction.Hands:
                    return "TriggerMove";
                case EnumMyAction.Move:
                    return "TriggerMove";
                case EnumMyAction.Idle:
                    return "TriggerIdle";
                case EnumMyAction.BeDead:
                    return "TriggerDead";
                default:
                    break;

            }
            throw (new Exception(""));
            return "";
        }
    }
   

}