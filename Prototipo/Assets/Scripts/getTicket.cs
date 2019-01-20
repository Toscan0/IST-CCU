using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class getTicket : MonoBehaviour {
	void Update () {
        GameObject alwaysPays = GameObject.Find("/AlwaysPays").gameObject;
        int current = alwaysPays.GetComponent<path>().getCurrent();
        

        if(current == 2)
        {
            foreach (Transform child in alwaysPays.transform)
            {

                if (child.gameObject.name == "Card")
                {
                    child.gameObject.SetActive(true);

                }

            }
        }
        GameObject alwaysPays1 = GameObject.Find("/AlwaysPays1").gameObject;
        int current1 = alwaysPays1.GetComponent<path>().getCurrent();
        

        if(current1 == 2)
        {
            foreach (Transform child in alwaysPays1.transform)
            {

                if (child.gameObject.name == "Card")
                {
                    child.gameObject.SetActive(true);

                }

            }
        }
        GameObject alwaysPays2 = GameObject.Find("/AlwaysPays2").gameObject;
        int current2 = alwaysPays2.GetComponent<path>().getCurrent();
        

        if(current2 == 2)
        {
            foreach (Transform child in alwaysPays2.transform)
            {

                if (child.gameObject.name == "Card")
                {
                    child.gameObject.SetActive(true);

                }

            }
        }
        GameObject alwaysPays3 = GameObject.Find("/AlwaysPays3").gameObject;
        int current3 = alwaysPays3.GetComponent<path>().getCurrent();
        

        if(current3 == 1)
        {
            foreach (Transform child in alwaysPays3.transform)
            {

                if (child.gameObject.name == "Card")
                {
                    child.gameObject.SetActive(true);

                }

            }
        }
        GameObject alwaysPays4 = GameObject.Find("/AlwaysPays4").gameObject;
        int current4 = alwaysPays4.GetComponent<path>().getCurrent();
        

        if(current4 == 5)
        {
            foreach (Transform child in alwaysPays4.transform)
            {

                if (child.gameObject.name == "Card")
                {
                    child.gameObject.SetActive(true);

                }

            }
        }
    }
}
