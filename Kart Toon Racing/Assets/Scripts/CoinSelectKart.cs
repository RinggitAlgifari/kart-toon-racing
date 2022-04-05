using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CoinSelectKart : MonoBehaviour
{
    public int Coin, HargaKart, Diamond;
    public Text CoinText, DiamondText;

    public GameObject LockObject, OwnObject;

    public int UnlockKart;

    public bool boolUnlockKart;

    public string kodeKart;

    public GameObject SelectColorPanel;
    
    // Start is called before the first frame update
    void Start()
    {
        Coin = PlayerPrefs.GetInt("Coin");
        Diamond = PlayerPrefs.GetInt("Diamond");
        CoinText.text = PlayerPrefs.GetInt("Coin", 0).ToString();
        DiamondText.text = PlayerPrefs.GetInt("Diamond", 0).ToString();

        UnlockKart = PlayerPrefs.GetInt(kodeKart, 1);
    }

    // Update is called once per frame
    void Update()
    {
        

        if (Input.GetKeyDown("r"))
        {
            PlayerPrefs.DeleteAll();
            Application.LoadLevel("KartSelect");
        }

        if (Input.GetKeyDown("="))
        {
            Coin += 5000;
            CoinText.text = Coin.ToString();
        }

        if (UnlockKart == 1){

            boolUnlockKart = false;
            LockObject.SetActive(true);
            OwnObject.SetActive(false);
            
        }
        if (UnlockKart == 2){

            boolUnlockKart = true;
            LockObject.SetActive(false);
            OwnObject.SetActive(true);
        }
    }

    public void BuyKart(){
        if (Coin >= HargaKart){
            Coin -= HargaKart;
            PlayerPrefs.SetInt("Coin", Coin);
            CoinText.text = Coin.ToString();
            UnlockKart = 1;
            if(UnlockKart == 1) // checks if you have the item
            {
                UnlockKart = 2;
                PlayerPrefs.SetInt(kodeKart, UnlockKart); // saves the gameobject
            }
        }
    }


    public void SelectColorOpen(){
        SelectColorPanel.SetActive(true);
    }

    public void SelectColorClose(){
        SelectColorPanel.SetActive(false);
    }
}
