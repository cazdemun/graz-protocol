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

    /*
      Scene Name vs Number on Queue:
      MenuScene (0)
      GrazScene (1)
      RestScene (2)
      ExitScene (3)
     */

    public void StartTraining()
    {
      // Triggers when button "Empezar" is clicked
      // Add empty user validation and loading userState (maybe in a different class)
      SceneManager.LoadScene(1);
    }

    public void CancelPhase()
    {
      // Triggers when Esc 
      // Don't forget confirmation pop up (for latter when paused is implemented)
      SceneManager.LoadScene(0);
    }

    public void EndPhase()
    {
      SceneManager.LoadScene(2);
    }

    public void NextPhase()
    {
      // UpdateUserState()
      SceneManager.LoadScene(1);
    }

    public void endTraining()
    {
      SceneManager.LoadScene(3);
    }

    public void ReturnToMenu()
    {
      SceneManager.LoadScene(0);
    }

    public void ExitGame()
    {
      // Additional function for ExitScene
    }

    ///////////////////////////
    // Deprecated
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