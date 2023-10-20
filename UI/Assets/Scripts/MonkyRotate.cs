using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MonkyRotate : MonoBehaviour
{
    private Vector3 vector;
    // Start is called before the first frame update
    void Start()
    {
        vector = Vector3.forward;
    }

    // Update is called once per frame
    void Update()
    {
        if (transform.rotation.z*180 > 90f)
        {
            vector = Vector3.back;
        }
        if (transform.rotation.z*180 < -90f)
        {
            vector = Vector3.forward;
        }
        transform.Rotate(vector*Time.deltaTime*20);

    }
}
