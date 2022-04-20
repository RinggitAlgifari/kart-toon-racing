using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Photon.Pun;

public class sceneChanger : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void changeScene(string sceneName)
    {
        PhotonNetwork.Disconnect();
        Application.LoadLevel(sceneName);
    }
}
