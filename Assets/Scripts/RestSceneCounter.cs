using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;

public class RestSceneCounter : MonoBehaviour
{
    [SerializeField]
    private float timeFinal;

    [SerializeField]
    private float timeElapsed;

    [SerializeField]
    private string sceneToLoad;

    private UserState userRef;
    public TextMeshProUGUI myText;

    private void Start()
    {
       Debug.Log("Initiating Rest");
       //Debug.Log(Globals.MiVar);
       userRef = Globals.userState;
       Debug.Log(userRef.getState());
       userRef.addStep();
       Debug.Log(userRef.getState());
       myText.text = "Sesión: " + (userRef.getSession() + 1) + " \nSerie: " + (userRef.getSerie() + 1) + " \nMovimiento: " + (userRef.getMovement() + 1) + " \nIntento: " + (userRef.getTrial() + 1);

       //Globals.userState.addStep();
       //Debug.Log(Globals.userState.getState());
    }

    private void Update()
    {
        if (Input.GetKey("escape"))
        {
            Application.Quit();
        }

        timeElapsed += Time.deltaTime;

        if (timeElapsed >= timeFinal)
        {
            SceneManager.LoadScene(sceneToLoad);
        }
    }
}
