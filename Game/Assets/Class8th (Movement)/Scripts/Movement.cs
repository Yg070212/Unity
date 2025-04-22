using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    void Start()
    {
        transform.position = new Vector3(0, 3, 0);
    }
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.W))
        {
            
        }
    }
}
