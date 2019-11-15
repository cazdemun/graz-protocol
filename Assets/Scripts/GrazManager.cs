using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using System;

public class GrazManager : MonoBehaviour
{
  public GameObject rightArrow;
  public GameObject leftArrow;
  public GameObject upArrow;

  private float timeElapsed = 0;
  public string sceneToLoad;
  private string movement;

  void Start()
  {
    upArrow.SetActive(false);
    rightArrow.SetActive(false);
    leftArrow.SetActive(false);
    movement = ReactCollector.movement;
  }

  void Update()
  {
    timeElapsed += Time.deltaTime;
    if(timeElapsed >= 4.0)
    {
      if (String.Equals(movement, "right")) {
        rightArrow.SetActive(true);
      }
      if (String.Equals(movement, "left")) {
        leftArrow.SetActive(true);
      }
      // upArrow.SetActive(true);
    }

    if (timeElapsed >= 8.0)
    {
      SceneManager.LoadScene(sceneToLoad);
    }
  }
}
