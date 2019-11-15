using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using System.Runtime.InteropServices;

public class RestManager : MonoBehaviour
{
  private float timeElapsed = 0;
  public string sceneToLoad;

  [DllImport("__Internal")]
  private static extern void newTrial();

  void Update()
  {
    timeElapsed += Time.deltaTime;
    if(timeElapsed >= 3.0)
    {
      SceneManager.LoadScene(sceneToLoad);
      newTrial();
    }
  }
}
