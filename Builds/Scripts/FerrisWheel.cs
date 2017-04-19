using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FerrisWheel : MonoBehaviour {

    GameObject btnPanel;
    PanelButton btnPanelScript;

    public Vector3 pivot;
    public Vector3 axis;
    public float rotate;
    
    /// <summary>
    /// Start()
    /// initialize variables for script
    /// </summary>
	void Start () {
        // retrieve game object and script references
        btnPanel = GameObject.FindGameObjectWithTag("Button");
        btnPanelScript = btnPanel.GetComponent<PanelButton>();
                
        // apply rotation rules
        pivot = GameObject.FindGameObjectWithTag("Base").transform.position;
        axis = new Vector3(1, 0, 0);
        rotate = 1.0f;
    }

    /// <summary>
    /// Update()
    /// utilize variables in script
    /// </summary>
    void Update () {
        // if user input, rotate wheel
        // only rotate if ferris wheel is still assembled
        if(btnPanelScript.isButtonRotate && !btnPanelScript.isButtonDisassemble)
            transform.RotateAround(pivot, axis, rotate);
    }
}
