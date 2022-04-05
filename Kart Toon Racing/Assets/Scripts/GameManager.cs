using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public GameObject PanelMenu, RecordResult, EndRecordButton;
    public int ShowLastCoinPanel;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void ShowLastCoinPanelOpen(){
        ShowLastCoinPanel = 1;
        PlayerPrefs.SetInt("ShowLastCoinPanel", ShowLastCoinPanel);
    }

    public void MenuBuka(){
        PanelMenu.SetActive(true);
        Time.timeScale = 0f;
    }
    public void MenuTutup(){
        PanelMenu.SetActive(false);
        Time.timeScale = 1f;
    }

    public void ScreenRecordStart(){
        PanelMenu.SetActive(false);
        Time.timeScale = 1f;
        EndRecordButton.SetActive(true);
    }

    public void ScreenRecordStop(){
        RecordResult.SetActive(true);
        Time.timeScale = 0f;
        EndRecordButton.SetActive(false);
    }


    public void ScreenRecordResultClose(){
        RecordResult.SetActive(false);
        Time.timeScale = 1f;
    }
}
