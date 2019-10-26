using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Sound : MonoBehaviour
{
    AudioSource beep;

    void Start()
    {
        beep = GetComponent<AudioSource>();
        beep.PlayDelayed(2.0f);
    }
}
