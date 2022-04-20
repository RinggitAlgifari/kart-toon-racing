using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;
using Photon.Pun;

public class NetworkManager : MonoBehaviour
{

    [SerializeField]
    Transform[] spawnPoints;

    // Start is called before the first frame update
    void Start()
    {
        if (PhotonNetwork.IsConnected)
        {
            spawnPlayer();
        }
    }

    void spawnPlayer()
    {
        if (PhotonNetwork.IsMasterClient)
            PhotonNetwork.Instantiate("Kart 1 MP", spawnPoints[0].position, Quaternion.identity);
        else
            PhotonNetwork.Instantiate("Kart 3 MP", spawnPoints[1].position, Quaternion.identity);
    }

}
