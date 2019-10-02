using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public static class Globals
{
       public const int MiVar = 100;
       const int ScreenFadingIn = -1;
       const int ScreenIdle = 0;
       const int ScreenFadingOut   =   1;
       public static float ScreenFadeAlpha = 1.0f;
       public static int ScreenFadeStatus = ScreenFadingIn;
}

public class GlobalStateManager : MonoBehaviour
{

}
