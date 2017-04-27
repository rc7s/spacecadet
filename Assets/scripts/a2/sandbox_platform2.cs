using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class sandbox_platform2 : MonoBehaviour {

	public sandboxcontroller controller;

	// Use this for initialization
	void Start () {

	}

	// Update is called once per frame
	void Update () {
		Vector3 pos = transform.position;
		pos.y = controller.platform2_height;
		transform.position = pos;
	}
}
