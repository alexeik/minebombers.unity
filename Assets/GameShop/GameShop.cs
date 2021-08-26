using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameShop : MonoBehaviour
{
    [SerializeField] List<GameShopItem> _listItem;
    [SerializeField] GameObject _prefab;
    [SerializeField] Transform _panelItem;
  
    private void Start()
    {
        foreach (var item in _listItem)
        {
            var pref = Instantiate(_prefab);
            pref.transform.SetParent(_panelItem,false);
            pref.GetComponent<ItemView>().Item = item;
            pref.GetComponent<ItemView>().UpdateView();
        }
    }

}
