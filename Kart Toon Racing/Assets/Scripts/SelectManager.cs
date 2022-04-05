using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SelectManager : MonoBehaviour
{
    public int angka;
    public GameObject kart1, kart2, kart3, kart4;

    public GameObject PlayerTerpilih, SpawnPlayer;
    // Start is called before the first frame update
    void Start()
    {
        
        
        angka = PlayerPrefs.GetInt("angka", 0);
    }

    // Update is called once per frame
    void Update()
    {
        //PlayerTerpilih.transform.SetParent(null);
        if (Input.GetKeyDown("x"))
        {
            PlayerPrefs.DeleteAll();
        }

        PlayerTerpilih = GameObject.FindGameObjectWithTag("Player");

        if (angka == 0){
            kart1.SetActive(true);
            kart2.SetActive(false);
            kart3.SetActive(false);
            kart4.SetActive(false);
        }
        if (angka == 1){
            kart1.SetActive(false);
            kart2.SetActive(true);
            kart3.SetActive(false);
            kart4.SetActive(false);
        }
        if (angka == 2){
            kart1.SetActive(false);
            kart2.SetActive(false);
            kart3.SetActive(true);
            kart4.SetActive(false);
        }
        if (angka == 3){
            kart1.SetActive(false);
            kart2.SetActive(false);
            kart3.SetActive(false);
            kart4.SetActive(true);
        }
    }
    public void Next(){
        angka++;

        if (angka == 4){
            angka = 0;
            kart1.SetActive(true);
            kart2.SetActive(false);
            kart3.SetActive(false);
            kart4.SetActive(false);
        }
        if (angka == 1){
            kart1.SetActive(false);
            kart2.SetActive(true);
            kart3.SetActive(false);
            kart4.SetActive(false);
        }
        if (angka == 2){
            kart1.SetActive(false);
            kart2.SetActive(false);
            kart3.SetActive(true);
            kart4.SetActive(false);
        }
        if (angka == 3){
            kart1.SetActive(false);
            kart2.SetActive(false);
            kart3.SetActive(false);
            kart4.SetActive(true);
        }
    }
    public void Back(){
        angka--;
        if (angka == -1){
            angka = 3;
            kart1.SetActive(false);
            kart2.SetActive(false);
            kart3.SetActive(false);
            kart4.SetActive(true);
        }
        if (angka == 2){
            kart1.SetActive(false);
            kart2.SetActive(false);
            kart3.SetActive(true);
            kart4.SetActive(false);
        }
        if (angka == 1){
            kart1.SetActive(false);
            kart2.SetActive(true);
            kart3.SetActive(false);
            kart4.SetActive(false);
        }
        if (angka == 0){
            kart1.SetActive(true);
            kart2.SetActive(false);
            kart3.SetActive(false);
            kart4.SetActive(false);
        }
    }

    public void PilihKart(){
        PlayerPrefs.SetInt("angka", angka);
        Application.LoadLevel("Demo");
        PlayerTerpilih.transform.position = SpawnPlayer.transform.position;
        
    }



}
