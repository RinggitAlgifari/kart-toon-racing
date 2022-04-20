using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollow : MonoBehaviour {

    public Transform target;

    public Vector3 offset;

    public GameObject CameraCenter;
    public Camera camera;

    bool CameraSwitcher;

    void Start() {
        target = GameObject.FindGameObjectWithTag("Player").transform;
        //StartCoroutine(CameraAktif());
    }
	
	// Update is called once per frame
	void Update () {
        transform.position = target.position + offset;
	}

    public void SwitchCamera(){
        CameraSwitcher = !CameraSwitcher;
        if (CameraSwitcher){
            CameraCenter.SetActive(true);
            camera.GetComponent<Camera>().enabled = false;
        }else{
            CameraCenter.SetActive(false);
            camera.GetComponent<Camera>().enabled = true;
        }
    }


    /*IEnumerator CameraAktif(){
        yield return new WaitForSeconds(1f);
        target = GameObject.FindGameObjectWithTag("Player").transform;
    }*/


} // class
