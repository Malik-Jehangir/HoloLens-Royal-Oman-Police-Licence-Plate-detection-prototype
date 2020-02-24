using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SplashFade : MonoBehaviour {



    public void Start()
    {
        StartCoroutine(LoadAfterDelay("MainScreen"));
    }

    IEnumerator LoadAfterDelay(string levelName)
    {
        yield return new WaitForSeconds(5); // wait 1 seconds
        Application.LoadLevel(levelName);

    }
}

