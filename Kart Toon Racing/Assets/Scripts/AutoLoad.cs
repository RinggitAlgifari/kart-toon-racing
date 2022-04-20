using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AutoLoad : MonoBehaviour
{
    public string SceneName;
    public float timeLoad;
    void Awake()
    {
        StartCoroutine(LoadKeMenu());
    }

    IEnumerator LoadKeMenu(){
        yield return new WaitForSeconds(timeLoad);
        Application.LoadLevel(SceneName);
    }
}
