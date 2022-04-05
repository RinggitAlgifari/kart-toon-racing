using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Finish : MonoBehaviour
{
    public int angka;
    public GameObject Line, SpawnStartline, SpawnGaris1, SpawnGaris2, DeleteLine, FinishCanvas, FinishCamera, FinishLine;

    public GameObject Arrow1, Arrow2, Arrow3, Arrow4;

    public GameObject PlayerTrigger;
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Line = GameObject.FindGameObjectWithTag("Line");
        SpawnStartline = GameObject.FindGameObjectWithTag("StartLine");
        SpawnGaris1 = GameObject.FindGameObjectWithTag("Garis1");
        SpawnGaris2 = GameObject.FindGameObjectWithTag("Garis2");
        DeleteLine = GameObject.FindGameObjectWithTag("DeleteLine");
        FinishCanvas = GameObject.FindGameObjectWithTag("FinishCanvas");
        FinishCamera = GameObject.FindGameObjectWithTag("FinishCamera");
        FinishLine = GameObject.FindGameObjectWithTag("FinishLine");
        Arrow1 = GameObject.FindGameObjectWithTag("Arrow1");
        Arrow2 = GameObject.FindGameObjectWithTag("Arrow2");
        Arrow3 = GameObject.FindGameObjectWithTag("Arrow3");
        Arrow4 = GameObject.FindGameObjectWithTag("Arrow4");
        PlayerTrigger = GameObject.FindGameObjectWithTag("PlayerTrigger");
    }

    void OnTriggerEnter(Collider col){
        if (col.gameObject.tag == "Line"){
            angka++;
            Debug.Log("Masuk");
        }

        if (angka == 1){
            if (col.gameObject.tag == "Line"){
                Line.transform.position = SpawnGaris1.transform.position;
                Line.transform.rotation = SpawnGaris1.transform.rotation;
            }
        }

        if (angka == 2){
            if (col.gameObject.tag == "Line"){
                Line.transform.position = SpawnGaris2.transform.position;
                Line.transform.rotation = SpawnGaris2.transform.rotation;
            }
        }

        if (angka == 3){
            if (col.gameObject.tag == "Line"){
                //Line.transform.position = SpawnStartline.transform.position;
                //Line.transform.rotation = SpawnStartline.transform.rotation;

                FinishLine.transform.position = SpawnStartline.transform.position;
                FinishLine.transform.rotation = SpawnStartline.transform.rotation;

                Line.transform.position = DeleteLine.transform.position;
                Line.transform.rotation = DeleteLine.transform.rotation;
            }
        }

        if (angka == 3){
            if (col.gameObject.tag == "FinishLine"){
                PlayerTrigger.SetActive(false);
                FinishCanvas.GetComponent<Canvas>().enabled = true;
                FinishCamera.GetComponent<Camera>().enabled = true;
                Debug.Log("Finish");
            }
        }

        if (col.gameObject.tag == "Pos1"){
            Arrow1.GetComponent<MeshRenderer>().enabled = false;
            Arrow2.GetComponent<MeshRenderer>().enabled = true;
        }
        if (col.gameObject.tag == "Pos2"){
            Arrow3.GetComponent<MeshRenderer>().enabled = false;
            Arrow4.GetComponent<MeshRenderer>().enabled = false;
        }
    }
}
