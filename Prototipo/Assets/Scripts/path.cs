using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class path : MonoBehaviour {
    public Transform[] target;
    public float speed;

    
    private int current;
    private float k = 0.0000001f; // 1e-5

    void Update () {
        bool samePos = verifyPos();
		if(!samePos)
        {
            Vector3 pos = Vector3.MoveTowards(transform.position, target[current].position, speed * Time.deltaTime);
            GetComponent<Rigidbody>().MovePosition(pos);
        }
        else
        {
            current = (current + 1) % target.Length;
        }
	}

    private bool verifyPos()
    {
        Vector3 objectPos = transform.position;
        Vector3 targetPos = target[current].position;

        float x = Mathf.Abs(objectPos.x - targetPos.x);
        float y = Mathf.Abs(objectPos.y - targetPos.y);
        float z = Mathf.Abs(objectPos.z - targetPos.z);

        if ((x < k) && (y < k) && (z < k))
        {
            return true;
        }

        return false;
    }

    public int getCurrent()
    {
        return current;
    }
}
