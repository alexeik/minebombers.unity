using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ItemView : MonoBehaviour
{
    [SerializeField]
    private Image _image;
    [SerializeField]
    private Text _price;
    [SerializeField]
    private Image _isSelected;
    [SerializeField]
    private Slider _count;

    public GameShopItem Item;

    public void UpdateView()
    {
        _isSelected.enabled = Item.IsSelected;
        _image.sprite = Item.Image;
        _price.text = Item.Price.ToString();
        _count.maxValue = Item.MaxCount;
        _count.value = Item.Count;
    }
}
