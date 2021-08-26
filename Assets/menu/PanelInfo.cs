using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PanelInfo : MonoBehaviour
{
    [SerializeField] List<Sprite> _SpritesInfo;
    private int _currentSprite;
    private Image _image;
    private void Awake()
    {
        _currentSprite = 0;
        _image = gameObject.GetComponent<Image>();
        _image.sprite = _SpritesInfo[_currentSprite];
    }
    private void Update()
    {
        if (Input.GetKeyUp(KeyCode.Escape))
            transform.gameObject.SetActive(false);
        if (Input.GetKeyUp(KeyCode.LeftArrow))
            ChangeInfo(-1);
        if (Input.GetKeyUp(KeyCode.RightArrow))
            ChangeInfo(1);
    }

    private void ChangeInfo(int changeIndex)
    {
        int newIndex = _currentSprite + changeIndex;
        if (newIndex < 0) newIndex = _SpritesInfo.Count-1;
        if (newIndex > _SpritesInfo.Count - 1) newIndex = 0;
        _currentSprite = newIndex;
        _image.sprite = _SpritesInfo[_currentSprite]; 
    }
}
