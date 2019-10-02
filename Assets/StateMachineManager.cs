using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using UnityEngine.SceneManagement;

public class StateMachineManager : MonoBehaviour
{
    public GameObject inputField;
    public string asdf;	
    public TMP_Text m_TextComponent;

    public void StartGrazScene()
    {
        // load a new scene
        SceneManager.LoadScene(1);
	asdf = m_TextComponent.GetComponent<TMP_Text>().text;
	Debug.Log(asdf);
    }

    public void OnChangeLogger() 
    {
	Debug.Log("this works but eats a letter");
	//asdf = inputField.GetComponent<Text>().text;
	asdf = m_TextComponent.GetComponent<TMP_Text>().text;
	Debug.Log(asdf);
    }

    public void Extra(TMP_Text wide) 
    {
	Debug.Log("this works but eats a letter");
	asdf = wide.GetComponent<TMP_Text>().text;
	Debug.Log(asdf);
    }
}