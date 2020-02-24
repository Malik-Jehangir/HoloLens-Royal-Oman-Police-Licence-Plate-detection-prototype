using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.WSA;

public class navigation2 : MonoBehaviour {

    
    public GameObject TV;
    public GameObject OI;
    public GameObject VI;
    public GameObject ar;
    public GameObject en;
    public void Start()
    {
        VI.SetActive(true);
        OI.SetActive(false);
        TV.SetActive(false);
        en.SetActive(false);
        ar.SetActive(false);

    }

    public void LoadAfterDelay0() //Vehicle
    {

        VI.SetActive(true);
        OI.SetActive(false);
        TV.SetActive(false);
        en.SetActive(false);
        ar.SetActive(false);


    }
    public void LoadAfterDelay1() //Owner Info
    {

        VI.SetActive(false);
        OI.SetActive(true);
        TV.SetActive(false);
        en.SetActive(false);
        ar.SetActive(false);


    }
   public void LoadAfterDelay2() //Traffic Violation
    {

        VI.SetActive(false);
        OI.SetActive(false);
        TV.SetActive(true);
        en.SetActive(false);
        ar.SetActive(false);


    }
    public void LoadAfterDelay3() //Traffic Violation
    {
        UnityEngine.Application.LoadLevel("MainScreen");

    }
    

         public void LoadAfterDelay4() //Traffic Violation
    {
        Launcher.LaunchUri(@"Skype:(+97333901092)?call",true);

    }
}
