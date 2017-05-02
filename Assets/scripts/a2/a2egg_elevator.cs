using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class a2egg_elevator : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		Vector3 pos = transform.position;
		pos.y = Mathf.PingPong(Time.time * 4, 17) + 73 ;
		transform.position = pos;
	}
}
