using System.Collections;
using System.Collections.Generic;
using UnityEngine;
[CreateAssetMenu]
public class GameShopItem : ScriptableObject
{
    [SerializeField]
    private int _price;
    [SerializeField]
    private int _count;
    [SerializeField]
    private int _maxCount;
    [SerializeField]
    private int _refundPrice;
    [SerializeField]
    private Sprite _image;
    [SerializeField]
    private string _name;

    public bool IsSelected;
    public Sprite Image => _image;
    public int Price => _price;
    public int MaxCount => _maxCount;
    public int Count => _count;

   
}
