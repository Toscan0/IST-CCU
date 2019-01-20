using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bodyController : MonoBehaviour {
    private GameObject cameraAux;
    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        cameraAux = GameObject.Find("Camera").gameObject;

        Vector3 eulerRotation = new Vector3(0, cameraAux.transform.eulerAngles.y, 0);

        transform.rotation = Quaternion.Euler(eulerRotation);
    }
}
