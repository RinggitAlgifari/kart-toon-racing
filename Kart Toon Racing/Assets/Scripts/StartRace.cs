using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class StartRace : MonoBehaviour
{
    public bool MobileController;
    public GameObject[] Enemy;
    public GameObject Player, CameraCinematic, CameraPlayer;
    public int i;

    public string ColorSelected;
    // Start is called before the first frame update
    void Start()
    {
        PlayerPrefs.GetString ("NewColor");
        //Player = GameObject.FindGameObjectWithTag("Player");
        CameraCinematic = GameObject.FindGameObjectWithTag("FinishCamera");
        //LampuHijau();
        StartCoroutine(KinematicPlayer());
        StartCoroutine(GASS());
        
    }

    // Update is called once per frame
    void Update()
    {
        Player = GameObject.FindGameObjectWithTag("Player");
    }
    
    public void LampuHijau(){
        for(i = 0; i < Enemy.Length; i++){
            Enemy[i].GetComponent<PowerslideKartPhysics.BasicWaypointFollowerDrift>().enabled = true;
        }
    }

    IEnumerator GASS(){
        yield return new WaitForSeconds(8.30f);
        CameraCinematic.GetComponent<Camera>().enabled = false;
        //Player.GetComponent<Rigidbody>().isKinematic = false;  //Not Solution, player Jumpy
        CameraPlayer.SetActive(true);
        //yield return new WaitForSeconds(2);
        Debug.Log("Majuuu");
        LampuHijau();
        if (MobileController == true){
            Player.GetComponent<PowerslideKartPhysics.KartInputMobile>().enabled = true;
        }
        if (MobileController == false){
            Player.GetComponent<PowerslideKartPhysics.KartInputPlayer>().enabled = true;
        }
        
    }

    IEnumerator KinematicPlayer(){
        yield return new WaitForSeconds(2f);
        //Player.GetComponent<Rigidbody>().isKinematic = true; //Not Solution, player Jumpy
        
    }
}