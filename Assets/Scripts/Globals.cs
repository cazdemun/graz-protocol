using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Globals : MonoBehaviour
{
    static public int money = 0;
    static public bool paused = false;
    static public string MiVar = "hola mi variable";
    static public UserState userState = new UserState();

    void Start(){
        Debug.Log("Initiating User State");
	//userState = new UserState();
	userState.setState(0);
        Debug.Log(userState.getState());
    }

    void Update(){
	if (Input.GetKey("escape"))
        {
            Application.Quit();
        }
    }
}
