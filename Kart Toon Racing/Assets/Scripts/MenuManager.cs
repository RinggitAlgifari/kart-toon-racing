using System;
using UnityEngine;
using UnityEngine.UI;

public class MenuManager : MonoBehaviour
{
    // Start is called before the first frame update\
    public GameObject AccelObj, ArcadePanel, AccelPanel;
    [Header("[ audio ]")]
    [SerializeField] Slider sliderBGM;
    [SerializeField] Slider sliderSFX;

    void Start()
    {
        sliderBGM.onValueChanged.AddListener(valueChangeBGM);
        sliderSFX.onValueChanged.AddListener(valueChangeSFX);
    }

    private void OnEnable()
    {
        sliderBGM.value = SoundS.Instance.GetBgmVol();
        sliderSFX.value = SoundS.Instance.GetSfxVol();
    }

    #region audio
    private void valueChangeSFX(float v)
    {
        SoundS.Instance.SetSFXMVol(v);
    }

    private void valueChangeBGM(float v)
    {
        SoundS.Instance.SetBGMVol(v);
    }
    #endregion

    // Update is called once per frame
    void Update()
    {
        
    }

    public void SelectTilt(){
        AccelObj.GetComponent<AcceleroManager>().enabled = true;
        AccelPanel.SetActive(true);
        ArcadePanel.SetActive(false);
    }

    public void SelectArcade(){
        AccelObj.GetComponent<AcceleroManager>().enabled = false;
        AccelPanel.SetActive(false);
        ArcadePanel.SetActive(true);
    }

    
}
