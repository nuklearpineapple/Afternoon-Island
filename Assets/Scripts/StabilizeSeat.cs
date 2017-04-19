using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StabilizeSeat : MonoBehaviour {

    public Quaternion qStart;

    /// <summary>
    /// Start()
    /// initialize variables for script
    /// </summary>
    void Start()
    {
        // initialize Quarternion for current rotation
        qStart = transform.rotation;
    }

    /// <summary>
    /// Update()
    /// utilize variables in script
    /// </summary>
    void Update()
    {
        // set rotation to the initial rotation every frame
        transform.rotation = qStart;
    }
}
