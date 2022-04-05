using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotateTest : MonoBehaviour
{
    public GameObject SpawnPoint;
    // Start is called before the first frame update
    void Start()
    {
        Vector3 eulerRotation = new Vector3(SpawnPoint.transform.eulerAngles.x, SpawnPoint.transform.eulerAngles.y, SpawnPoint.transform.eulerAngles.z);
        transform.rotation = Quaternion.Euler(eulerRotation);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
