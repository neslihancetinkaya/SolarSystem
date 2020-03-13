using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class venus : MonoBehaviour
{
    public sun s;
    public float rotationSpeed = 0;
    public float orbitSpeed = 20;
    // Start is called before the first frame update
    void Start()
    {
        // v.transform.Rotate(0, Time.deltaTime * rotationSpeed, 0);
    }
 

    // Update is called once per frame
    void Update()
    {
        transform.Rotate(Time.deltaTime * rotationSpeed, 0, 0);
        transform.RotateAround(s.transform.position, Vector3.up, Time.deltaTime * orbitSpeed);
    }
}
