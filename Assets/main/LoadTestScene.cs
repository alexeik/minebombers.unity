using UnityEngine;
using System.Collections;

public class LoadTestScene : MonoBehaviour {

	// Use this for initialization
	void Start () {
        Screen.sleepTimeout = SleepTimeout.NeverSleep;
	}
	
	// Update is called once per frame
	void Update () {
        if (Input.GetKeyUp(KeyCode.Return))
        {
            DontDestroyOnLoad(GameObject.Find("tk2dCamera"));
            Application.LoadLevel("Init");
        }

        if (Input.touchCount > 0 &&
          Input.GetTouch(0).phase == TouchPhase.Stationary)
        {
            DontDestroyOnLoad(GameObject.Find("tk2dCamera"));
            Application.LoadLevel("Init");
        }
	}
}
