using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Menu : MonoBehaviour
{
    public GameObject FreeSelect, CupSelect, MultiSelect;
    public GameObject loading;

    public int Coin, XP, Level, Diamond;

    public Text CoinText, TextXP, TextLevel, DiamondText;

    public GameObject ParameterXP;

    public GameObject EnterNamePanel, ProfilePanel;
    public string PlayerName;
    public InputField inputField;
    public GameObject inputFieldText;
    public Text PlayerNameDisplay, PlayerNameDisplay2;
    public float tick;
    public int LastCoin;
    public int LastXP;
    public Text LastCoinText;

    public GameObject LastCoinPanel;
    public int ShowLastCoinPanel;
    // Start is called before the first frame update
    void Start()
    {
        Level = 1;
        //
        LastCoin = PlayerPrefs.GetInt("LastCoin");
        LastXP = PlayerPrefs.GetInt("LastXP");
        //XP = PlayerPrefs.GetInt("XP");
        Diamond = PlayerPrefs.GetInt("Diamond");
        //TextXP.text = PlayerPrefs.GetInt("XP", 0).ToString();
        PlayerName = PlayerPrefs.GetString("PlayerName", PlayerName);
        ShowLastCoinPanel = PlayerPrefs.GetInt("ShowLastCoinPanel");
    }

    // Update is called once per frame
    void Update()
    {
        Coin = PlayerPrefs.GetInt("Coin");
        XP = PlayerPrefs.GetInt("XP");
        
        PlayerNameDisplay.GetComponent<Text>().text = PlayerName;
        PlayerNameDisplay2.GetComponent<Text>().text = PlayerName;
        TextXP.GetComponent<Text>().text = XP + " XP";
        DiamondText.text = PlayerPrefs.GetInt("Diamond", 0).ToString();
        CoinText.text = PlayerPrefs.GetInt("Coin", 0).ToString();
        TextXP.text = PlayerPrefs.GetInt("XP", 0).ToString();
        LastCoinText.text = PlayerPrefs.GetInt("LastCoin", 0).ToString();
        if (Input.GetKeyDown("1"))
        {
            PlayerPrefs.DeleteAll();
            Application.LoadLevel("Menu");
        }

        if (Input.GetKeyDown("x"))
        {
            XP += 10;
            PlayerPrefs.SetInt("XP", XP);
            
            
        }

        if (Input.GetKeyDown("d"))
        {
            Diamond += 10;
            PlayerPrefs.SetInt("Diamond", Diamond);
        }

        if (Input.GetKeyDown("="))
        {
            Coin += 5000;
            
            CoinText.text = Coin.ToString();
        }

        if (Level == 1){
            //ParameterXP.transform.Translate(35, 0, 0);
            if (XP >= 100){
                Level += 1;
                PlayerPrefs.SetInt("Level", Level);
                ResetXP();
                TextLevel.text = PlayerPrefs.GetInt("Level", 0).ToString();
                
            }
        }

        if (Level == 2){
            //ParameterXP.transform.Translate(25, 0, 0);
            if (XP >= 150){
                Level += 1;
                PlayerPrefs.SetInt("Level", Level);
                ResetXP();
                TextLevel.text = PlayerPrefs.GetInt("Level", 0).ToString();
                
            }
        }

        if (Level == 3){
            if (XP >= 200){
                Level += 1;
                PlayerPrefs.SetInt("Level", Level);
                ResetXP();
                TextLevel.text = PlayerPrefs.GetInt("Level", 0).ToString();
            }
        }
        if (ShowLastCoinPanel == 1){
            LastCoinPanel.SetActive(true);
        }
        if (ShowLastCoinPanel == 2){
            LastCoinPanel.SetActive(false);
        }
    }

    public void DapatCoin(){
        Coin = LastCoin + Coin;
        LastCoin = 0;
        PlayerPrefs.SetInt("LastCoin", LastCoin);
        PlayerPrefs.SetInt("Coin", Coin);
        
        XP = LastXP + XP;
        LastXP = 0;
        PlayerPrefs.SetInt("LastXP", LastXP);
        PlayerPrefs.SetInt("XP", XP);

        ShowLastCoinPanel = 2;
        LastCoinPanel.SetActive(false);
        PlayerPrefs.SetInt("ShowLastCoinPanel", ShowLastCoinPanel);
    }

    public void ResetXP(){
        XP = 0;
        PlayerPrefs.SetInt("XP", XP);
        ParameterXP.transform.Translate(-360, 0, 0);
    }

    public void munculLoading(){
        loading.SetActive(true);
        //playbutton.SetActive(false);
    }

    public void intLoadScene (string level)
	{
		Application.LoadLevel(level);
        
	}

    public void FreePlay(){
        FreeSelect.SetActive(true);
        
        
    }

    public void CloseSelectTrack(){
        FreeSelect.SetActive(false);
    }

    public void CupPlay(){
        
        CupSelect.SetActive(true);
        
        
    }

    public void MultiPlay(){
        
        MultiSelect.SetActive(true);
    
    }

    public void ResetAll(){
        PlayerPrefs.DeleteAll();
        Application.LoadLevel("Menu");
    }

    public void TambahCoin(){
        Coin += 5000;    
        CoinText.text = Coin.ToString();
    }

    public void bukaEnterName(){
        EnterNamePanel.SetActive(true);
    }

    public void cancelEnterName(){
        EnterNamePanel.SetActive(false);
    }

    public void ProfilePanelOpen(){
        ProfilePanel.SetActive(true);
    }

    public void ProfilePanelClose(){
        ProfilePanel.SetActive(false);
    }

    public void ChangeName(){
        EnterNamePanel.SetActive(false);
        PlayerName = inputFieldText.GetComponent<Text>().text;
        PlayerPrefs.SetString("PlayerName", PlayerName);
    }
}
