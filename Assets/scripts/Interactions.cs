using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Interactions : MonoBehaviour {
    public Rigidbody rb;
	public bool pickup;
    // Use this for initialization
    void Start () {
		pickup = false;
	}
	
	// Update is called once per frame
	void Update () {
	}

    void OnTriggerStay(Collider other)
    {
        if (other.tag == "key")
        {
			if (Input.GetMouseButtonDown (0)) {
				if (pickup = false) {
					pickup = true;
				}
				if (pickup = true) {
					pickup = false;
				}
			}
			if (pickup = true) {
				other.transform.position = gameObject.transform.position;
				if (Input.GetMouseButtonDown (0)) {
					pickup = false;
				}
			}
        }
    }
}
