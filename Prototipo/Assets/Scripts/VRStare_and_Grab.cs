using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class VRStare_and_Grab : MonoBehaviour {
    public float stare_time = 0f; // timer 
    public Transform VRHand;
    public GameObject text;

    private Vector3 parentPos;
    private Vector3 direction;
    private bool grabbed;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        stare_time = stare_time + Time.deltaTime;
        //if (!grabbed)
        //{
            Transform body = GameObject.Find("Player/Body").transform;
            foreach (Transform child in body)
            {
                if (child.gameObject.name == "Card") // player already have a ticket
                {
                    Debug.Log("player already have a ticket");
                    text.SetActive(true);
                    Text myText = text.GetComponent<Text>();
                    myText.text = "You already have a ticket\n" +
                        "<size=14><i>Look to your left hand to check</i></size>";
                    grabbed = true;
                    break;
                }
            }
        //}
        if (!grabbed && stare_time >= 2f) // once a certain amount of time has passed, the object will be 'grabbed'
        {
            GrabObject();
            grabbed = true;
        }
	}

    public void ResetStareTime()
    {
        Text myText = text.GetComponent<Text>();
        myText.text = "";
        text.SetActive(false);

        stare_time = 0f;
    }

    public void GrabObject()
    {
        Transform card = this.transform.Find("Card");       
        Transform playerBody = GameObject.Find("Body").transform;
        Vector3 playerLeftHand = new Vector3(-12, 14, 2);

        card.SetParent(playerBody);
        card.localPosition = playerLeftHand;
        card.Rotate(0, 90, 0);

        Debug.Log("Card grabbed!");
        text.SetActive(true);
        Text myText = text.GetComponent<Text>();
        myText.text = "Ticket Grabbed\n" +
            "<size=14><i>Look to your left hand to check</i></size>";
    }
}
