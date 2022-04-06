using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;

public class SoundS : MonoBehaviour
{
    public static SoundS Instance;

    [SerializeField] AudioMixer audioMixer;

    private void Awake()
    {
        if (Instance == null)
        {
            Instance = this;
            DontDestroyOnLoad(this);
        }
        else
        {
            Destroy(gameObject);
        }
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }
    #region Get

    public float GetBgmVol()
    {
        float vol = 0f;
        audioMixer.GetFloat("BgmVol", out vol);
        return vol;
    }

    public float GetSfxVol()
    {
        float vol = 0f;
        audioMixer.GetFloat("SfxVol", out vol);
        return vol;
    }
    #endregion

    public void SetBGMVol(float v)
    {
        audioMixer.SetFloat("BgmVol", v);
    }
    public void SetSFXMVol(float v)
    {
        audioMixer.SetFloat("SfxVol", v);
    }
}
