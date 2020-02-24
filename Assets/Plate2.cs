using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Plate2 : MonoBehaviour {

    public void Start()
    {
        StartCoroutine(LoadAfterDelay("loading"));
    }

    IEnumerator LoadAfterDelay(string levelName)
    {
        yield return new WaitForSeconds(5); // wait 1 seconds
        Application.LoadLevel(levelName);

    }
}
