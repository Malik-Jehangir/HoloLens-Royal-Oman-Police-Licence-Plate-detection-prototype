using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class plate1 : MonoBehaviour {

    public void Start()
    {
        StartCoroutine(LoadAfterDelay("ScanFinal"));
    }

    IEnumerator LoadAfterDelay(string levelName)
    {
        yield return new WaitForSeconds(7); // wait 1 seconds
        Application.LoadLevel(levelName);
        
    }
}
