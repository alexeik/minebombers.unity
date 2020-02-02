using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel;

namespace Assets.cls.GameOptions
{
    //
// Created by SharpDevelop.
// User: akozlov
// Date: 20.01.2015
// Time: 14:59
// 
// To change this template use Tools | Options | Coding | Edit Standard Headers.
//



public class GameOptions 
{


	//DONE: сделать дефолт. отображать эту структуру на страницу Options.
	//DONE: сделать другой шаблон для progress bar , который еще содержит в центре текстбокс, который слинкован с value .через templatebinding
	private int _cash;
	private int _treasures;
	private int _time;
	private int _players;
	private int _speed;
	private int _bombdamage;
	private string _darkness;
	private string _freemarket;
	private string _selling;
	private string _winner;
	private int _rounds;
	private int cashl = 50;
	private int cashr = 2650;
	private int treasuresl = 0;
	private int treasuresr = 75;
	private int timel = 9;
	private int timer = 1359;
	private int playersl = 0;
	private int playersr = 4;
	private int speedl = 0;
	private int speedr = 100;
	private int bdl = 0;
	private int bdr = 100;
	private int roundsl = 0;
	private int roundsr = 55;
	//DONE: контроль на максимумы и минимумы значений должен быть.хранить значения выключателей в integer
	public int PlayerLives { get; set; }
	private bool _darknessbool;
	private bool _freemarketbool;
	private bool _sellingbool;

	private bool _winnerbool;
	public int Player1DeathCount { get; set; }
	public int Player2DeathCount { get; set; }
	public int Player3DeathCount { get; set; }
	public int Player4DeathCount { get; set; }
	public int RoundsDone { get; set; }
	public bool Player1ShopReady { get; set; }
	public bool Player2ShopReady { get; set; }
	public bool Player3ShopReady { get; set; }
	public bool Player4ShopReady { get; set; }

	public int RoundsLeft {
		get { return Rounds - RoundsDone; }
	}


	public int Cash {
		get { return _cash; }

		set {
			if (value < 0) {
				if (_cash == cashl)
					return;
				_cash = _cash - 100;
			}
			if (value > 0) {
				if (_cash == cashr)
					return;
				_cash = _cash + 100;
			}
		}
	}
	public int Treasures {
		get { return _treasures; }
		set {
			if (value < 0) {
				if (_treasures == treasuresl)
					return;
				_treasures = _treasures - 1;
			}
			if (value > 0) {
				if (_treasures == treasuresr)
					return;
				_treasures = _treasures + 1;
			}
		}
	}
	public int Rounds {
		get { return _rounds; }
		set {
			if (value < 0) {
				if (_rounds == roundsl)
					return;
				_rounds = _rounds - 1;
			}
			if (value > 0) {
				if (_rounds == roundsr)
					return;
				_rounds = _rounds + 1;
			}
		}
	}
	public int Time {
		get { return _time; }
		set {
			if (value < 0) {
				if (_time == timel)
					return;
				_time = _time - 15;
			}
			if (value > 0) {
				if (_time == timer)
					return;
				_time = _time + 15;
			}
		}
	}
	public int Players {
		get { return _players; }
		set {
			if (value < 0) {
				if (_players == playersl)
					return;
				_players = _players - 1;
			}
			if (value > 0) {
				if (_players == playersr)
					return;
				_players = _players + 1;
			}
		}
	}
	public int Speed {
		get { return _speed; }
		set {
			if (value < 0) {
				if (_speed == speedl)
					return;
				_speed = _speed - 1;
			}
			if (value > 0) {
				if (_speed == speedr)
					return;
				_speed = _speed + 1;
			}
		}
	}
	public int BombDamage {
		get { return _bombdamage; }
		set {
			if (value < 0) {
				if (_bombdamage == bdl)
					return;
				_bombdamage = _bombdamage - 1;
			}
			if (value > 0) {
				if (_bombdamage == bdr)
					return;
				_bombdamage = _bombdamage + 1;
			}
		}
	}

	public string Darkness {
		get { return _darkness; }
		set {
           // DarknessBool = Convert.ToBoolean(value);

			if (value == "1") {
				_darkness = "/mymir2;component/media/Pages/optionson.png";
			}
			if (value == "-1") {
				_darkness = "/mymir2;component/media/Pages/optionsoff.png";
			}
		}
	}
	public string DarknessNegative {
		get {
			if (_darkness == "/mymir2;component/media/Pages/optionson.png") {
				return "/mymir2;component/media/Pages/optionsoff.png";
			}
			if (_darkness == "/mymir2;component/media/Pages/optionsoff.png") {
				return "/mymir2;component/media/Pages/optionson.png";
			}
            return "-1";
		}
	}

	public string FreeMarket {
		get { return _freemarket; }
		set {
           // freemarketBool = Convert.ToBoolean(value);
			if (value == "1") {
				_freemarket = "/mymir2;component/media/Pages/optionson.png";
			}
			if (value == "-1") {
				_freemarket = "/mymir2;component/media/Pages/optionsoff.png";
			}
		}
	}
	public string FreeMarketNegative {
		get {
			if (_freemarket == "/mymir2;component/media/Pages/optionson.png") {
				return "/mymir2;component/media/Pages/optionsoff.png";
			}
			if (_freemarket == "/mymir2;component/media/Pages/optionsoff.png") {
				return "/mymir2;component/media/Pages/optionson.png";
			}
            return "-1";
		}
	}
	public string Selling {
		get { return _selling; }
		set {
			//sellingBool =Convert.ToBoolean(value);
			if (value == "1") {
				_selling = "/mymir2;component/media/Pages/optionson.png";
			}
			if (value == "-1") {
				_selling = "/mymir2;component/media/Pages/optionsoff.png";
			}
		}
	}
	public string SellingNegative {
		get {
			if (_selling == "/mymir2;component/media/Pages/optionson.png") {
				return "/mymir2;component/media/Pages/optionsoff.png";
			}
			if (_selling == "/mymir2;component/media/Pages/optionsoff.png") {
				return "/mymir2;component/media/Pages/optionson.png";
			}
            return "-1";
		}
	}
	public string Winner {
		get { return _winner; }
		set {
			//winnerBool =Convert.ToBoolean(value);

			if (value == "1") {
				_winner = "/mymir2;component/media/Pages/optionson.png";
			}
			if (value == "-1") {
				_winner = "/mymir2;component/media/Pages/optionsoff.png";

			}
		}
	}
	public string WinnerNegative {
		get {

			if (_winner == "/mymir2;component/media/Pages/optionson.png") {
				return "/mymir2;component/media/Pages/optionsoff.png";

			}

			if (_winner == "/mymir2;component/media/Pages/optionsoff.png") {
				return "/mymir2;component/media/Pages/optionson.png";

			}
            return "-1";
		}
	}

	public bool DarknessBool {
		get { return _darknessbool; }
		set { _darknessbool = value; }
	}

	public bool freemarketBool {
		get { return _freemarketbool; }
		set { _freemarketbool = value; }
	}

	public bool sellingBool {
		get { return _sellingbool; }
		set { _sellingbool = value; }
	}

	public bool winnerBool {
		get { return _winnerbool; }
		set { _winnerbool = value; }
	}
	public GameOptions()
	{
		_cash = 2650;
		_treasures = 75;
		_rounds = 22;
		_time = 399;
		_players = 2;
		_speed = 43;
		_bombdamage = 91;
		Darkness = "1";
		FreeMarket = "1";
		Selling = "1";
		Winner = "-1";
		PlayerLives = 3;
	}
	public void UpdateProperty(int index, int value)
	{
		switch (index) {
			case 1:
				Cash = value;
			

				break;
			case 3:
				Treasures = value;
			

				break;
			case 5:
				Rounds = value;
			

				break;
			case 7:
				Time = value;
			

				break;
			case 9:
				Players = value;
			

				break;
			case 11:
				Speed = value;
			

				break;
			case 13:
				BombDamage = value;
			

				break;
			case 15:
                Darkness = (-value).ToString();

				

				break;
			case 17:
                FreeMarket = (-value).ToString();
			

				break;
			case 19:
                Selling = (-value).ToString();
			

				break;
			case 21:
				Winner = (-value).ToString();
			

				break;
			case 23:
				break;
			case 25:

				break;

		}
	}

   

	public PlayerKeyboard PK1 { get; set; }
	public PlayerKeyboard PK2 { get; set; }
	public PlayerKeyboard PK3 { get; set; }
	public PlayerKeyboard PK4 { get; set; }


}

}
