using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using System.Runtime.InteropServices;

public class LoadFinal : MonoBehaviour
{
    [DllImport("__Internal")]
    private static extern void ChangeScene();

    [SerializeField]
    private float timeFinal;

    [SerializeField]
    private float timeElapsed;

    [SerializeField]
    private string sceneToLoad;

    [SerializeField]
    private GameObject arriba;

    [SerializeField]
    private GameObject derecha;

    [SerializeField]
    private GameObject izquierda;

    [SerializeField]
    private int indice;

    private UserState userRef;

    private void Start()
    {
       Debug.Log("Starting Graz Protocol!");
       arriba.SetActive(false);
       derecha.SetActive(false);
       izquierda.SetActive(false);
       userRef = Globals.userState;
       indice = userRef.getMovement() + 1;
       ChangeScene();                  
    }

    private void Update()
    {
        if (Input.GetKey("escape"))
        {
            Application.Quit();
        }

        timeElapsed += Time.deltaTime;

        if(timeElapsed >= 3.0)
        {
            switch(indice)
            {
                case 1:
                    arriba.SetActive(true);
                    break;
                case 2:
                    derecha.SetActive(true);
                    break;
                case 3:
                    izquierda.SetActive(true);
                    break;
            }
        }

        if (timeElapsed >= timeFinal)
        {
            SceneManager.LoadScene(sceneToLoad);
        }
    }
}
