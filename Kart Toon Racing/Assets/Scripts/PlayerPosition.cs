using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerPosition : MonoBehaviour
{
    public GameObject Cp;
    public GameObject CheckpointHolder;

    public GameObject[] Cars;
    public Transform[] CheckpointPosition;
    public GameObject[] CheckpointForEachCar;

    public Text PositionTxt;

    private int totalCars;
    private int totalCheckpoints;
    // Start is called before the first frame update
    void Start()
    {
        totalCars = Cars.Length;
        totalCheckpoints = CheckpointHolder.transform.childCount;

        setCheckpoints();
        SetCarPosition();
    }

    void setCheckpoints(){
        CheckpointPosition = new Transform[totalCheckpoints];

        for (int i = 0; i < totalCheckpoints; i++){
            CheckpointPosition[i] = CheckpointHolder.transform.GetChild(i).transform;
        }

        CheckpointForEachCar = new GameObject[totalCars];

        for (int i = 0; i < totalCars; i++){
            CheckpointForEachCar[i] = Instantiate(Cp, CheckpointPosition[0].position, CheckpointPosition[0].rotation);
            CheckpointForEachCar[i].name = "CP" + i;
            CheckpointForEachCar[i].layer = 9 + i;
        }
    }

    void SetCarPosition(){
        for (int i = 0; i < totalCars; i++){
            Cars[i].GetComponent<PowerslideKartPhysics.CarCPManager>().CarPosition = i + 1;
            Cars[i].GetComponent<PowerslideKartPhysics.CarCPManager>().CarNumber = i;
        }

        PositionTxt.text = "POS " + Cars[3].GetComponent<PowerslideKartPhysics.CarCPManager>().CarPosition + "/" + totalCars;
    }

    public void CarCollectedCp(int carNumber, int cpNumber){
        CheckpointForEachCar[carNumber].transform.position = CheckpointPosition[cpNumber].transform.position;
        CheckpointForEachCar[carNumber].transform.rotation = CheckpointPosition[cpNumber].transform.rotation;

        comparePositions(carNumber);
    }

    void comparePositions(int carNumber){
        if(Cars[carNumber].GetComponent<PowerslideKartPhysics.CarCPManager>().CarPosition > 1){
            GameObject currentCar = Cars[carNumber];
            int currentCarPos = currentCar.GetComponent<PowerslideKartPhysics.CarCPManager>().CarPosition;
            int currentCarCp = currentCar.GetComponent<PowerslideKartPhysics.CarCPManager>().cpCrossed;

            GameObject carInFront = null;
            int carInFrontPos = 0;
            int carInFrontCp = 0;

            for (int i = 0; i < totalCars; i++){
                if(Cars[i].GetComponent<PowerslideKartPhysics.CarCPManager>().CarPosition == currentCarPos-1){
                    carInFront = Cars[i];
                    carInFrontCp = carInFront.GetComponent<PowerslideKartPhysics.CarCPManager>().cpCrossed;
                    carInFrontPos = carInFront.GetComponent<PowerslideKartPhysics.CarCPManager>().CarPosition;
                    break;
                }
            }

            if (currentCarCp > carInFrontCp){
                currentCar.GetComponent<PowerslideKartPhysics.CarCPManager>().CarPosition = currentCarPos - 1;
                carInFront.GetComponent<PowerslideKartPhysics.CarCPManager>().CarPosition = carInFrontPos + 1;

                Debug.Log("Car " + carNumber + " has over taken " + carInFront.GetComponent<PowerslideKartPhysics.CarCPManager>().CarNumber);
            }

            PositionTxt.text = "POS " + Cars[3].GetComponent<PowerslideKartPhysics.CarCPManager>().CarPosition + "/" + totalCars;
        }
    }
}
