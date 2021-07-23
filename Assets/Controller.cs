using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Controller : MonoBehaviour
{
    GameObject go;
    GameObject cursor;
    SpriteRenderer sr;
    Transform tf;
    float[] menu_items = new float[] { 0.9f, 0.45f, -0.05f, -0.5f };
    Action[] menu_delegates = new Action[5];
    object[,] menu_struct = new object[5, 5];
    int[,] current_menu;
    int itemcounter = 0;
    // Start is called before the first frame update
    int inMenu = 0;
    int[,] menuKeyboardNav;
    void Start()
    {
        GameObject go = GameObject.Find("Menu");
        GameObject cursor = GameObject.Find("Cursor");
        sr = go.GetComponent<SpriteRenderer>();
        CurrentGOS = sr;
        tf = cursor.GetComponent<Transform>();
        menu_delegates[0] = () => StartGame();
        menu_delegates[1] = () => StartOptions();
        menu_delegates[2] = () => StartInfo();
        menu_delegates[3] = () => StartExit();


    }
   
    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyUp(KeyCode.Return))
        {
   
            if (inMenu == 0)
            {
                sr.sortingOrder = 2;
                inMenu = 1;
                return;
            }
            if (inMenu ==1 )
            {
                menu_delegates[itemcounter]();
            }

        }
        if (Input.GetKeyUp(KeyCode.DownArrow))
        {
            itemcounter += 1;
            if (itemcounter >= menu_items.Length - 1)
            {
                itemcounter = 0;
            }

            tf.position = new Vector3(tf.position.x, menu_items[itemcounter]);

        }

        if (Input.GetKeyUp(KeyCode.Escape))
        {
     
            numbers.Pop().sortingOrder = 0;
            return;
        }
 
    }
    public SpriteRenderer CurrentGOS;
    public static Stack<SpriteRenderer> numbers = new Stack<SpriteRenderer>();

    public void StartGame()
    {
        SceneManager.LoadScene("Init", LoadSceneMode.Single);
    }

    public void StartOptions()
    {

    }
    public void StartInfo()
    {
        inMenu = 3;
        GameObject go = GameObject.Find("Info1");
        go.GetComponent<SpriteRenderer>().sortingOrder = 3;
        numbers.Push(go.GetComponent<SpriteRenderer>());
    }
    public void StartExit()
    {
        Application.Quit(0);
    }
}
