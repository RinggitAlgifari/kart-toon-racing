using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

namespace PowerslideKartPhysics
{
    public class CarCPManager : MonoBehaviour
{
    public int CarNumber;
    public int cpCrossed = 0;

    public int CarPosition;

    public Kart scriptKart;

    public PlayerPosition playerPosition;

    public bool isHillTrack;

    void Start(){
    
    }
    private void OnTriggerEnter(Collider other){
        if (other.gameObject.CompareTag("CP")){
            cpCrossed += 1;
            playerPosition.CarCollectedCp(CarNumber, cpCrossed);
        }
    }
    void Update (){   
        if (isHillTrack == false){
            if (CarPosition == 1){
                scriptKart.GetComponent<PowerslideKartPhysics.Kart>().maxSpeed = 45f;
            }
            if (CarPosition == 2){
                scriptKart.GetComponent<PowerslideKartPhysics.Kart>().maxSpeed = 60f;
            }

            if (CarPosition == 3){
                scriptKart.GetComponent<PowerslideKartPhysics.Kart>().maxSpeed = 80f;
            }
        }

        if (isHillTrack == true){
            if (CarPosition == 1){
                scriptKart.GetComponent<PowerslideKartPhysics.Kart>().maxSpeed = 50f;
            }
            if (CarPosition == 2){
                scriptKart.GetComponent<PowerslideKartPhysics.Kart>().maxSpeed = 55f;
            }

            if (CarPosition == 3){
                scriptKart.GetComponent<PowerslideKartPhysics.Kart>().maxSpeed = 60f;
            }
        }
        }
    }
}