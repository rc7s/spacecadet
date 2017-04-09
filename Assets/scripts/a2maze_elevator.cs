using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class a2maze_elevator : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		Vector3 pos = transform.position;
		pos.y = Mathf.PingPong(Time.time * 4, 20) + 87 ;
		transform.position = pos;
	}
}
