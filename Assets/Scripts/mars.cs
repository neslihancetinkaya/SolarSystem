using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class mars : MonoBehaviour
{
    public sun s;
    public float rotationSpeed = 0;
    public float orbitSpeed = 0;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.Rotate(Time.deltaTime * rotationSpeed, 0, 0);
        transform.RotateAround(s.transform.position, Vector3.up, Time.deltaTime * orbitSpeed);
    }
}
