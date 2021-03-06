﻿using UnityEngine;
using System.Collections;
using Enums;

public interface IDecal
{
	GameObject LeftImage { get; set; }
    GameObject RightImage { get; set; }
    GameObject UpImage { get; set; }
    GameObject DownImage { get; set; }
	void UpdateSide(Side s, int x, int y);
	void Update(int x, int y, Side side, WhoIs who);
	void Remove(int x, int y, Side side, WhoIs who);
	//DONE: сделать объект декорация.
	//сделать слой декораций.
	//Каждая декорация может управлять четырьям картинками.
	//    Координаты картинок расчитываются исходя из 10 на 10 пикселей.
	
	//Когда в square классе, осуществляется переход на тип ground, то отправляется команда в доску декораций
	//всем декорациям которые прилегают к этому square.
	//Как убрать декорацию:если статус square изменен "state изменился" или m_current изменилось, то надо вызвать декорации по координатам square 
	//Декорация просчитает нужность картинок и уберет. обычно если state изменился,то декорации надо убрать(зачистить)
	
	//    Каждая декорация расчитывает какие картинки нужно вывести .Сама декорация может добавить image на canvas игры.
	//    Расчет какую картинку вывести:
	//Смотрим в доску и определяем , что под декорацией. 
	//    Если там песок или скала, то выводим картинку ,притом на нужной стороне
	//Сторону можно определить по коориданатам. если декорация выше squre то нижняя грань, если ниже, то верхняя.
	//    Если уровень один, но левее, то правая грань, если правее, то левая грань.
}
