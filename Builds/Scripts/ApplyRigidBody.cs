using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ApplyRigidBody : MonoBehaviour {
    
    GameObject btnPanel;
    PanelButton btnPanelScript;
    Rigidbody rgbody;

    /// <summary>
    /// Start()
    /// initialize variables for script
    /// </summary>
    void Start () {
        // retrieve game object and script references
        btnPanel = GameObject.FindGameObjectWithTag("Button");
        btnPanelScript = btnPanel.GetComponent<PanelButton>();
    }

    /// <summary>
    /// Update()
    /// utilize variables in script
    /// </summary>
    void Update () {
        // if user input, disassemble wheel
        if (btnPanelScript.isButtonDisassemble)
            rgbody = gameObject.AddComponent<Rigidbody>();
    }
}
