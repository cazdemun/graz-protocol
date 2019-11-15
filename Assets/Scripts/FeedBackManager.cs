using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FeedBackManager : MonoBehaviour
{
  public LineRenderer lineRenderer;
  private float _x = 0.0f;
  private float limit = 5.0f;
  
  void Start()
  {
    lineRenderer.SetPosition(0, new Vector3(0.0f, 0.0f, 0.0f));  
    lineRenderer.SetPosition(1, new Vector3(_x, 0.0f, 0.0f));  
  }

  void applyFeedBack(float delta) {
    if (_x + delta > limit || _x + delta < -limit) {
      return;
    }
    _x += delta;
    lineRenderer.SetPosition(1, new Vector3(_x, 0.0f, 0.0f));  
  }

  void Update()
  {
    applyFeedBack(Time.deltaTime);
  }
}