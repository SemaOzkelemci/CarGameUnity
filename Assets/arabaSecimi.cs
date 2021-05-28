using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;  

public class arabaSecimi: MonoBehaviour
{
    public GameObject carSky;
    public GameObject carTocus;
    public GameObject carTor;
    public GameObject carFoc;
    public GameObject carChev;
    public GameObject panel;

    // Start is called before the first frame update
    void Start()
    {
        carSky.SetActive(false);
        carTocus.SetActive(false);
        carTor.SetActive(false);
        carFoc.SetActive(false);
        carChev.SetActive(false);
        panel.SetActive(true);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void carSkyButton(){
        carSky.SetActive(true);
        carTocus.SetActive(false);
        carTor.SetActive(false);
        carFoc.SetActive(false);
        carChev.SetActive(false);
        panel.SetActive(false);
    }
    public void carTocusButton(){
        carSky.SetActive(false);
        carTocus.SetActive(true);
        carTor.SetActive(false);
        carFoc.SetActive(false);
        carChev.SetActive(false);
        panel.SetActive(false);
    }
    public void carTorButton(){
        carSky.SetActive(false);
        carTocus.SetActive(false);
        carTor.SetActive(true);
        carFoc.SetActive(false);
        carChev.SetActive(false);
        panel.SetActive(false);
    }
    public void carFocButton(){
        carSky.SetActive(false);
        carTocus.SetActive(false);
        carTor.SetActive(false);
        carFoc.SetActive(true);
        carChev.SetActive(false);
        panel.SetActive(false);
    }
    public void carChevButton(){
        carSky.SetActive(false);
        carTocus.SetActive(false);
        carTor.SetActive(false);
        carFoc.SetActive(false);
        carChev.SetActive(true);
        panel.SetActive(false);
    }
    


}

