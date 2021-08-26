using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEditor.UI;

public class MainMenu : MonoBehaviour
{
    [SerializeField]
    GameObject _cursorPrefab;
    [SerializeField]
    List<Transform> _cursorPositions;
    [SerializeField]
    GameObject _panelInfo;
    private int _currentPosition;
    private bool _cursorActive;
    private void Awake()
    {
        _cursorActive = true;
        _currentPosition = 0;
        SetCursor(_currentPosition);
    }

    private void Update()
    {
        if (!_cursorActive)
        {
            _cursorActive = !_panelInfo.activeSelf;
            return;
        }
        if (Input.GetKeyUp(KeyCode.UpArrow))
            ChangePositionCursor(1);
        if (Input.GetKeyUp(KeyCode.DownArrow))
            ChangePositionCursor(-1);
        if (Input.GetKeyUp(KeyCode.Space))
            SelectMenu(_currentPosition);

    }

    private void SelectMenu(int currentPosition)
    {     
        switch(_cursorPositions[currentPosition].name)
        {
            case "QuitPosition":
                Application.Quit();
                break;
            case "NewGamePosition":
                SceneManager.LoadScene("Init", LoadSceneMode.Single);
                break;
            case "InfoPosition":
                _panelInfo.SetActive(true);
                _cursorActive = false;
                break;
        }
    }

    private void ChangePositionCursor(float position)
    {
        int newPosition = _currentPosition-(int)position;
        if (newPosition <= -1) newPosition = _cursorPositions.Count - 1;
        if (newPosition >= _cursorPositions.Count) newPosition = 0;
        _currentPosition = newPosition;
        SetCursor(_currentPosition);

    }
    private void SetCursor(int position)
    {
        _cursorPrefab.transform.localPosition = _cursorPositions[position].localPosition;
    }
}
