using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class success : MonoBehaviour {
    public Text txt;
    public GameObject my;
    public GameObject your;
    public void Start()
    {
        my.SetActive(false);
        StartCoroutine(LoadAfterDelay());
    }

    IEnumerator LoadAfterDelay()
    {
        yield return new WaitForSeconds(10); // wait 1 seconds
        txt.GetComponent<UnityEngine.UI.Text>().text = "Information retrieved";

        my.SetActive(true);
        your.SetActive(false);

    }
}
