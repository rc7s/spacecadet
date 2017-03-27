using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Interactions : MonoBehaviour {
    public Rigidbody rb;
    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
    
	}

    void OnTriggerStay(Collider other)
    {
        if (other.tag == "key" && Input.GetMouseButton(0))
        {
            other.transform.position = gameObject.transform.position;
        }
    }
}
