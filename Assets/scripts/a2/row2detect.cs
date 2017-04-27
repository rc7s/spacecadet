using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class row2detect : MonoBehaviour {

	public GameObject plate1;
	public GameObject plate2;
	public GameObject plate3;
	public GameObject plate4;

	public sandboxcontroller controller;

	// Use this for initialization
	void Start () {

	}

	// Update is called once per frame
	void Update () {

	}

	void OnCollisionStay(Collider other){
		if (other.tag == "a2smallcubes") {
			controller.row2weight += 1;
		}
	}
}
