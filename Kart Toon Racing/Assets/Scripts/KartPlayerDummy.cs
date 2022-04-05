using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KartPlayerDummy : MonoBehaviour
{
    public GameObject Player, playerDummy;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Player = GameObject.FindGameObjectWithTag("Player");
        playerDummy.transform.parent = Player.transform;
    }
}
