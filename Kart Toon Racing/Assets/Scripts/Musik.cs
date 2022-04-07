using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Musik : MonoBehaviour
{
    void Awake()
    {
        StartCoroutine(LoadKeMenu());
        /*GameObject[] objs = GameObject.FindGameObjectsWithTag("music");

        if (objs.Length > 1)
        {
            Destroy(this.gameObject);
        }

        DontDestroyOnLoad(this.gameObject);*/
    }

    IEnumerator LoadKeMenu(){
        yield return new WaitForSeconds(2f);
        Application.LoadLevel("Menu");
    }
}
