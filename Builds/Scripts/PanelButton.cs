using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PanelButton : MonoBehaviour {

    GameObject lineOfSight;
    LineOfSight sightScript;

    public bool isButtonRotate;
    public bool isButtonDisassemble;

    /// <summary>
    /// Start()
    /// initialize variables for script
    /// </summary>
    void Start () {
        // initially, rotation and disassemble wheel are off
        isButtonRotate = false;
        isButtonDisassemble = false;

        // retrieve game object and script references
        lineOfSight = GameObject.FindGameObjectWithTag("Player");
        sightScript = lineOfSight.GetComponent<LineOfSight>();
    }

    /// <summary>
    /// Update()
    /// utilize variables in script
    /// </summary>
    void Update () {
        // check for user input
        // determine whether to rotate wheel or not
        if (Input.GetMouseButtonDown(0) && isButtonRotate == false)
            isButtonRotate = true;
        else if(Input.GetMouseButtonDown(0) && isButtonRotate == true)
            isButtonRotate = false;

        // check for user input
        // determine whether to disassemble wheel or not
        if (sightScript.isKeyEPressed && isButtonDisassemble == false)
            isButtonDisassemble = true;
    }
}
