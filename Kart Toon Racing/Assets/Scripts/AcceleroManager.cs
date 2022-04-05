using System.Collections;
using System.Collections.Generic;
using PowerslideKartPhysics;
using UnityEngine;

public class AcceleroManager : MonoBehaviour
{

    [SerializeField] InputManager inputManager;
    public Vector3 tilt;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        tilt = Input.acceleration;
        Debug.Log("tiltX: " + tilt.x+ ", tiltY: " + tilt.y+ ", tiltZ: " + tilt.z);

        if (tilt.x < -0.14f)
        {
            inputManager.SetSteerMobile(-1f);
        }
        else if (tilt.x > 0.14f)
        {
            inputManager.SetSteerMobile(1f);
        }
        else
        {
            inputManager.SetSteerMobile(0f);
        }
    }
}
