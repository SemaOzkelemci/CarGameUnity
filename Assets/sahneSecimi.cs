using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement; 

public class sahneSecimi : MonoBehaviour
{
    public void coastalSahnesiGecis(){
        SceneManager.LoadScene("Drift Track");
    }
     public void sprintSahnesiGecis(){
        SceneManager.LoadScene("Sprint Track");
    }
    public void ovalSahnesiGecis(){
        SceneManager.LoadScene("Oval Track");
    }
    public void f8SahnesiGecis(){
        SceneManager.LoadScene("F8 Track");
    }
    public void f1SahnesiGecis(){
        SceneManager.LoadScene("F1 Track");
    }
}