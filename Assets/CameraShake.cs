using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraShake : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        gameObject.transform.position = new Vector3(-0.001f, 0, 0);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
