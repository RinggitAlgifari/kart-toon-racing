using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ChangeColor : MonoBehaviour
{

    public bool Kart2Color;
    public GameObject cube, cube2;
    public Texture texture1, texture2;
    public Renderer cubeRenderer, cubeRenderer2;

    public string warnaMobil;

    
    // Start is called before the first frame update
    void Start()
    {
        if (Kart2Color == true){
            cubeRenderer = cube.GetComponent<Renderer>();
            cubeRenderer2 = cube2.GetComponent<Renderer>();
            gameObject.GetComponent<Button>().onClick.AddListener(ChangeMaterial);
        }
        if (Kart2Color == false){
            cubeRenderer = cube.GetComponent<Renderer>();
            gameObject.GetComponent<Button>().onClick.AddListener(ChangeMaterial);
        }
    
    }

    // Update is called once per frame
    /*void Update()
    {
        if (Kart2Color == true){
            cubeRenderer.material.mainTexture = texture1;
            cubeRenderer2.material.mainTexture = texture2;
        }
    }*/

    public void ChangeMaterial(){
        if (Kart2Color == true){
            cubeRenderer.material.mainTexture = texture1;
            cubeRenderer2.material.mainTexture = texture2;
            PlayerPrefs.SetString("warnaMobil", warnaMobil);
        }
        if (Kart2Color == false){
            cubeRenderer.material.mainTexture = texture1;
            PlayerPrefs.SetString("warnaMobil", warnaMobil);
        }
        
    }
}
