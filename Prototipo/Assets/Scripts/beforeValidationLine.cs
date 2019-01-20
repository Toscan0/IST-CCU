using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class beforeValidationLine : MonoBehaviour {

    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.name == "Player")
        {
            GameObject greenBox = GameObject.Find("/Player/Body/Box/Green Box");
            GameObject redBox = GameObject.Find("/Player/Body/Box/Red Box");

            greenBox.SetActive(false);
            redBox.SetActive(false);
        }
    }

}

