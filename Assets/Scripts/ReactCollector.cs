using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ReactCollector : MonoBehaviour
{
  public string sceneToLoad;
  public static string movement;  

  void startGraz(string _movement, string mode){
    movement = _movement;

    if (mode == "training") {
      SceneManager.LoadScene("GrazProtocolScene");
    }
    if (mode == "feedback") {
      SceneManager.LoadScene("FeedBackScene");
    }
  }
}
