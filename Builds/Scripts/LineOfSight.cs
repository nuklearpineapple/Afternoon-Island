using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LineOfSight : MonoBehaviour {

    private RaycastHit vision; // detect Raycast collision
    public float rayLength; // assign length to raycast
    public bool isKeyEPressed; // check for user clicking 'E'
    
	// Use this for initialization
	void Start () {
        // initialize
        rayLength = 4.0f;
        isKeyEPressed = false;
	}
	
	// Update is called once per frame
	void Update () {
		// if raycast hits a collider in the scene
        if(Physics.Raycast(Camera.main.transform.position, Camera.main.transform.forward, out vision, rayLength))
        {
            // if user is looking at object, interact with 'E'
            if(Input.GetKeyDown (KeyCode.E))
            {
                isKeyEPressed = true;
            }
        }
	}
}
