using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using UnityEngine.InputSystem;

public class CloseGame : MonoBehaviour
{
    private TouchControls touchControls;
    bool exit = false;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //bool escKey = true;// touchControls.Touch.TouchInput.ReadValue<Vector2> 
        //if (escKey) //Input.GetKeyUp(KeyCode.Escape)) //added for android exit
        //{
        //    if (Application.platform == RuntimePlatform.Android)
        //    {
        //        AndroidJavaObject activity = new AndroidJavaClass("com.unity3d.player.UnityPlayer").GetStatic<AndroidJavaObject>("currentActivity");
        //        activity.Call<bool>("moveTaskToBack", true);
        //    }
        //    else
        //    {
        //        Application.Quit();
        //    }
        //}
    }

    public void Close()
    {
        Application.Quit();
    }
}
