using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerFinish : MonoBehaviour
{
    public int JuaraBerapa, LastCoin, LastXP;
    public GameObject Bintang1, Bintang2, Bintang3, BintangDummy;
    public GameObject TextJuara1, TextJuara2, TextJuara3, TextJuara4;
    public string PlayerName, OpponentName;
    public Text TextLastCoin, TextLastXP;

    public bool isPlayer;
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(DisableBintang());
        //LastCoin = PlayerPrefs.GetInt("Coin");
        PlayerName = PlayerPrefs.GetString("PlayerName", PlayerName);
    }

    // Update is called once per frame
    void Update()
    {
        //Stars Result
        /*if (PlayerName == "Player 1" ){
            Bintang1 = GameObject.Find("Star (1)");
            Bintang2 = GameObject.Find("Star (2)");
            Bintang3 = GameObject.Find("Star (3)");
        }
        if ((PlayerName == "Player 2") || (PlayerName == "Player 3" ) || (PlayerName == "Player 4" )){
            BintangDummy = GameObject.Find("Star Dummy");
        }*/

        if ((PlayerName == PlayerName)/* || (PlayerName == "Player 2" ) || (PlayerName == "Player 3" ) || (PlayerName == "Player 4" )*/){
            //TextLastCoin = GameObject.Find("TextLastCoinPlayer").GetComponent<Text>();
            //TextLastXP = GameObject.Find("TextLastXPPlayer").GetComponent<Text>();
            if (isPlayer == true){
                Bintang1 = GameObject.FindGameObjectWithTag("Star1");
                Bintang2 = GameObject.FindGameObjectWithTag("Star2");
                Bintang3 = GameObject.FindGameObjectWithTag("Star3");

                BintangDummy = GameObject.FindGameObjectWithTag("StarDummy");

                TextLastCoin = GameObject.Find("TextLastCoinPlayer").GetComponent<Text>();
                TextLastXP = GameObject.Find("TextLastXPPlayer").GetComponent<Text>();
            }
            if (isPlayer == false){
                TextLastCoin = GameObject.Find("TextScoreDummy").GetComponent<Text>();
                TextLastXP = GameObject.Find("TextXPDummy").GetComponent<Text>();
            }
            
        }
        /*if ((OpponentName == OpponentName) || (OpponentName == "Enemy 2" ) || (OpponentName == "Enemy 3" )){
            TextLastCoin = GameObject.Find("TextLastCoinDummy").GetComponent<Text>();
            TextLastXP = GameObject.Find("TextLastXPDummy").GetComponent<Text>();

            Bintang1 = GameObject.FindGameObjectWithTag("StarDummy");
            Bintang2 = GameObject.FindGameObjectWithTag("StarDummy");
            Bintang3 = GameObject.FindGameObjectWithTag("StarDummy");
            BintangDummy = GameObject.FindGameObjectWithTag("StarDummy");
        }*/

        TextJuara1 = GameObject.FindGameObjectWithTag("TextJuara1");
        TextJuara2 = GameObject.FindGameObjectWithTag("TextJuara2");
        TextJuara3 = GameObject.FindGameObjectWithTag("TextJuara3");
        TextJuara4 = GameObject.FindGameObjectWithTag("TextJuara4");

        
        

        JuaraBerapa = PlayerPrefs.GetInt("JuaraBerapa");
        if (Input.GetKeyDown("r"))
        {
            PlayerPrefs.DeleteAll();
            //Application.LoadLevel("Demo");
        }

        if (Input.GetKeyDown("="))
        {
            LastCoin += 100;
        }

        if (Input.GetKeyDown("f"))
        {
            
        }

        PlayerPrefs.SetInt("LastCoin", LastCoin);
        PlayerPrefs.SetInt("LastXP", LastXP);

        if (LastCoin == 100){
            Bintang1.GetComponent<Image>().enabled = true;
            Bintang2.GetComponent<Image>().enabled = true;
            Bintang3.GetComponent<Image>().enabled = true;
            PlayerPrefs.SetInt("LastXP", LastXP);
            TextLastXP.text = PlayerPrefs.GetInt("LastXP", 0).ToString();
        }
        if (LastCoin == 50){
            Bintang1.GetComponent<Image>().enabled = true;
            Bintang2.GetComponent<Image>().enabled = true;
            PlayerPrefs.SetInt("LastXP", LastXP);
            TextLastXP.text = PlayerPrefs.GetInt("LastXP", 0).ToString();
        }
        if (LastCoin == 10){
            Bintang1.GetComponent<Image>().enabled = true;
            PlayerPrefs.SetInt("LastXP", LastXP);
            TextLastXP.text = PlayerPrefs.GetInt("LastXP", 0).ToString();
        }
    }


    void OnTriggerEnter(Collider col){
        if (col.gameObject.tag == "FinishLine"){
            JuaraBerapa++;
            PlayerPrefs.SetInt("JuaraBerapa", JuaraBerapa);

            if (JuaraBerapa == 1){
                //PlayerName = PlayerPrefs.GetString("Name", PlayerName);
                if (isPlayer == true){
                    TextJuara1.GetComponent<Text>().text = PlayerName;
                }
                if (isPlayer == false){
                    TextJuara1.GetComponent<Text>().text = OpponentName;
                }
                LastCoin = 100;
                LastXP += 30;
                PlayerPrefs.SetInt("LastCoin", LastCoin);
                TextLastCoin.text = PlayerPrefs.GetInt("LastCoin", 0).ToString();
            }
            if (JuaraBerapa == 2){
                //PlayerName = PlayerPrefs.GetString("Name", PlayerName);
                if (isPlayer == true){
                    TextJuara2.GetComponent<Text>().text = PlayerName;
                }
                if (isPlayer == false){
                    TextJuara2.GetComponent<Text>().text = OpponentName;
                }
                LastCoin = 50;
                LastXP += 20;
                PlayerPrefs.SetInt("LastCoin", LastCoin);
                TextLastCoin.text = PlayerPrefs.GetInt("LastCoin", 0).ToString();
            }
            if (JuaraBerapa == 3){
                //PlayerName = PlayerPrefs.GetString("Name", PlayerName);
                if (isPlayer == true){
                    TextJuara3.GetComponent<Text>().text = PlayerName;
                }
                if (isPlayer == false){
                    TextJuara3.GetComponent<Text>().text = OpponentName;
                }
                LastCoin = 10;
                LastXP += 10;
                PlayerPrefs.SetInt("LastCoin", LastCoin);
                TextLastCoin.text = PlayerPrefs.GetInt("LastCoin", 0).ToString();
            }
            if (JuaraBerapa == 4){
                //PlayerName = PlayerPrefs.GetString("Name", PlayerName);
                if (isPlayer == true){
                    TextJuara4.GetComponent<Text>().text = PlayerName;
                }
                if (isPlayer == false){
                    TextJuara4.GetComponent<Text>().text = OpponentName;
                }
                LastCoin = 0;
                
                PlayerPrefs.SetInt("LastCoin", LastCoin);
                TextLastCoin.text = PlayerPrefs.GetInt("LastCoin", 0).ToString();
            }
        }
    }

    IEnumerator DisableBintang(){
        yield return new WaitForSeconds(1f);
        Bintang1.GetComponent<Image>().enabled = false;
        Bintang2.GetComponent<Image>().enabled = false;
        Bintang3.GetComponent<Image>().enabled = false;
        JuaraBerapa = 0;
    }
}
