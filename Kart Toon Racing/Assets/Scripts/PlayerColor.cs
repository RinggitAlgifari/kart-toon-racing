using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerColor : MonoBehaviour
{
    public bool Kart2Color;
    public string warnaMobil;
    public Renderer Body, Char;
    public Texture BodyTex1, CharTex1;
    public Texture BodyTex2, CharTex2;
    public Texture BodyTex3, CharTex3;
    public Texture BodyTex4, CharTex4;
    public Texture BodyTex5, CharTex5;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        warnaMobil = PlayerPrefs.GetString("warnaMobil", warnaMobil);
        if(warnaMobil == "Color1"){
            if(Kart2Color == true){
                Body.material.mainTexture = BodyTex1;
                Char.material.mainTexture = CharTex1;
            }
            if(Kart2Color == false){
                Body.material.mainTexture = BodyTex1;
            }
        }
        if(warnaMobil == "Color2"){
            if(Kart2Color == true){
                Body.material.mainTexture = BodyTex2;
                Char.material.mainTexture = CharTex2;
            }
            if(Kart2Color == false){
                Body.material.mainTexture = BodyTex2;
            }
        }
        if(warnaMobil == "Color3"){
            if(Kart2Color == true){
                Body.material.mainTexture = BodyTex3;
                Char.material.mainTexture = CharTex3;
            }
            if(Kart2Color == false){
                Body.material.mainTexture = BodyTex3;
            }
        }
        if(warnaMobil == "Color4"){
            if(Kart2Color == true){
                Body.material.mainTexture = BodyTex4;
                Char.material.mainTexture = CharTex4;
            }
            if(Kart2Color == false){
                Body.material.mainTexture = BodyTex4;
            }
        }
        if(warnaMobil == "Color5"){
            if(Kart2Color == true){
                Body.material.mainTexture = BodyTex5;
                Char.material.mainTexture = CharTex5;
            }
            if(Kart2Color == false){
                Body.material.mainTexture = BodyTex5;
            }
        }
    }
}
