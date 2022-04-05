using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class RaceResult : MonoBehaviour
{
    public Text TextJuara1,TextJuara2,TextJuara3,TextJuara4;
    public GameObject Player1, Player2, Player3, Player4;

    public GameObject Juara1, Juara2;

    public int Posisi;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnTriggerEnter(Collider col){
        if ((col.gameObject.tag == "Player") || (col.gameObject.tag == "Enemy")){
            Posisi++;
            if (Posisi == 1){
                Debug.Log("Kamu Juara 1");
            }
            if (Posisi == 2){
                Debug.Log("Kamu Juara 2");
            }
            if (Posisi == 3){
                Debug.Log("Kamu Juara 3");
            }
            if (Posisi == 4){
                Debug.Log("Kamu Juara 4");
            }
        }
    }
}
