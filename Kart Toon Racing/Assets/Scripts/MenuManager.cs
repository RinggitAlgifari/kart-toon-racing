using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MenuManager : MonoBehaviour
{
    // Start is called before the first frame update\
    public GameObject AccelObj, ArcadePanel, AccelPanel;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void SelectTilt(){
        AccelObj.GetComponent<AcceleroManager>().enabled = true;
        AccelPanel.SetActive(true);
        ArcadePanel.SetActive(false);
    }

    public void SelectArcade(){
        AccelObj.GetComponent<AcceleroManager>().enabled = false;
        AccelPanel.SetActive(false);
        ArcadePanel.SetActive(true);
    }

    
}
