using Assets.cls.Player.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Assets.cls.Player
{

    public class PlayerSoul 
    {

        // Private timer As Storyboard
        //Private bw As New BackgroundWorker
        //Private t As DispatcherTimer

        private MoveDirection _PlayerDirection;
        private int PlayerStep;
        private DateTime t1;
        private DateTime t2;
        private int elapsed;
        public void Activate()
        {
            t1 = System.DateTime.Now;
            FrameCounter = 0;
            return;


            //t = New DispatcherTimer
            //t.Interval = New TimeSpan(500)
            //' AddHandler CompositionTarget.Rendering, AddressOf DASY
            //AddHandler t.Tick, AddressOf DASY
            //t.Start()
            //'t = New System.Threading.Timer(New System.Threading.TimerCallback(AddressOf DASY), SynchronizationContext.Current, 0, 30)
            //'подходит этот таймер.а нимация плавная.
            //'
        }

        public void Deactivate()
        {
            //t.Stop()
        }
        private int FrameCounter;
   
     
     
        public event MoveEventHandler Move;
        public delegate void MoveEventHandler(int length, MoveDirection direction);
        public event UpdateImageEventHandler UpdateImage;
        public delegate void UpdateImageEventHandler(int length, MoveDirection direction);

        public PlayerSoul()
        {
        }
        public PlayerSoul(int length, MoveDirection direction)
        {
            PlayerDirection = direction;
            PlayerStep = length;
        }

        public MoveDirection PlayerDirection
        {
            get { return _PlayerDirection; }
            set { _PlayerDirection = value; }
        }

    }

}
