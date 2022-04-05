using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class Spawner : MonoBehaviour
{
    public GameObject PlayerObj;
    public GameObject SpawnPoint, CanvasSpawner;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        PlayerObj = GameObject.FindGameObjectWithTag("Player");
        
    }

    void OnTriggerEnter(Collider col){
        if (col.gameObject.tag == "PlayerTrigger"){
            CanvasSpawner.SetActive(true);
            StartCoroutine(SpawnPlayer());
        }
    }

    IEnumerator SpawnPlayer(){
        yield return new WaitForSeconds(1f);
        //PlayerObj.GetComponent<Rigidbody>().isKinematic = true;
        PlayerObj.GetComponent<PowerslideKartPhysics.Kart>().enabled = false;
        PlayerObj.GetComponent<PowerslideKartPhysics.KartInputPlayer>().enabled = false;
        PlayerObj.transform.position = SpawnPoint.transform.position;

        yield return new WaitForSeconds(0.5f);
        Debug.Log("rotasi");
        Vector3 eulerRotation = new Vector3(SpawnPoint.transform.eulerAngles.x, SpawnPoint.transform.eulerAngles.y, SpawnPoint.transform.eulerAngles.z);
        PlayerObj.transform.rotation = Quaternion.Euler(eulerRotation);

        //PlayerObj.GetComponent<Rigidbody>().isKinematic = false;
        PlayerObj.GetComponent<PowerslideKartPhysics.Kart>().enabled = true;
        PlayerObj.GetComponent<PowerslideKartPhysics.KartInputPlayer>().enabled = true;

        CanvasSpawner.SetActive(false);
    }
}
