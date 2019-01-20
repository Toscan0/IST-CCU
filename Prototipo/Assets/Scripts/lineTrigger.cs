using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class lineTrigger : MonoBehaviour {
    private bool valid = false;

    private Transform box;

    private GameObject greenBox;
    private GameObject redBox; 

    private Vector3 parentPos;
    AudioSource audioData;

    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.name == "Player")
        {
            box = other.transform.Find("Body/Box");

            // Deactivate boxes if any is active. (simulates the player exiting the validation area)
            if (greenBox && greenBox.activeSelf) {
                greenBox.SetActive(false);
                return;
            }
            if (redBox && redBox.activeSelf) {
                redBox.SetActive(false);
                return;
            }

            // find a card in the Player.
            valid = !!other.transform.Find("Body/Card");

            if (valid)
            {
                // always active green box && inactive red box
                greenBox = box.Find("Green Box").gameObject;
                greenBox.SetActive(true);

                redBox = box.Find("Red Box").gameObject;
                redBox.SetActive(false);
                

                parentPos = GameObject.Find("Player").transform.position;
                greenBox.transform.position = new Vector3(parentPos.x, parentPos.y, parentPos.z);
            }
            else
            {
                // always inactive green box && active red box
                greenBox = box.Find("Green Box").gameObject;
                greenBox.SetActive(false);

                redBox = box.Find("Red Box").gameObject;
                redBox.SetActive(true);
                //audioData = GetComponent<AudioSource>();
                //audioData.Play(0);

                parentPos = GameObject.Find("Player").transform.position;
                redBox.transform.position = new Vector3(parentPos.x, parentPos.y, parentPos.z);
                //redBox.transform.localEulerAngles = new Vector3(0, 180, 0);
            }
        }
        if (other.gameObject.name == "NeverPays")
        {
            GameObject redBoxNeverPays = GameObject.Find("/NeverPays/Box/Red Box");
            if (redBoxNeverPays.activeSelf)
            {
                redBoxNeverPays.SetActive(false);
            }
            else
            {
                redBoxNeverPays.SetActive(true);
                //audioData = GetComponent<AudioSource>();
                //audioData.Play(0);
            }

        }
        if (other.gameObject.name == "NeverPays1")
        {
            GameObject redBoxNeverPays = GameObject.Find("/NeverPays1/Box/Red Box");
            if (redBoxNeverPays.activeSelf)
            {
                redBoxNeverPays.SetActive(false);
            }
            else
            {
                redBoxNeverPays.SetActive(true);
                //audioData = GetComponent<AudioSource>();
                //audioData.Play(0);
            }

        }
        if (other.gameObject.name == "AlwaysPays")
        {
            GameObject greenBoxAlwaysPays = GameObject.Find("/AlwaysPays/Box/Green Box");
            if (greenBoxAlwaysPays.activeSelf)
            {
                greenBoxAlwaysPays.SetActive(false);
            }
            else
            {
                greenBoxAlwaysPays.SetActive(true);
            }

        }
        if (other.gameObject.name == "AlwaysPays1")
        {
            GameObject greenBoxAlwaysPays = GameObject.Find("/AlwaysPays1/Box/Green Box");
            if (greenBoxAlwaysPays.activeSelf)
            {
                greenBoxAlwaysPays.SetActive(false);
            }
            else
            {
                greenBoxAlwaysPays.SetActive(true);
            }

        }
        if (other.gameObject.name == "AlwaysPays2")
        {
            GameObject greenBoxAlwaysPays = GameObject.Find("/AlwaysPays2/Box/Green Box");
            if (greenBoxAlwaysPays.activeSelf)
            {
                greenBoxAlwaysPays.SetActive(false);
            }
            else
            {
                greenBoxAlwaysPays.SetActive(true);
            }

        }
        if (other.gameObject.name == "AlwaysPays3")
        {
            GameObject greenBoxAlwaysPays = GameObject.Find("/AlwaysPays3/Box/Green Box");
            if (greenBoxAlwaysPays.activeSelf)
            {
                greenBoxAlwaysPays.SetActive(false);
            }
            else
            {
                greenBoxAlwaysPays.SetActive(true);
            }

        }
        if (other.gameObject.name == "AlwaysPays4")
        {
            GameObject greenBoxAlwaysPays = GameObject.Find("/AlwaysPays4/Box/Green Box");
            if (greenBoxAlwaysPays.activeSelf)
            {
                greenBoxAlwaysPays.SetActive(false);
            }
            else
            {
                greenBoxAlwaysPays.SetActive(true);
            }

        }
        
    }

}
