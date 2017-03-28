using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Level1_p1fin : MonoBehaviour {

    public GameObject checkpoint;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    void OnTriggerStay(Collider other)
    {
        if(other.tag == "key")
        {
            Destroy(checkpoint);
        }
    }
}
