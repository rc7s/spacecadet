using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class sandboxcontroller : MonoBehaviour {

	public int row1weight = 0;
	public int row2weight = 0;
	public int row3weight = 0;

	public float platform1_height;
	public float platform2_height;
	public float platform3_height;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		platform1_height = Mathf.PingPong(Time.time * 4, 10*row1weight) + 36.43f;
		platform2_height = Mathf.PingPong(Time.time * 4, 10*row2weight) + 36.43f;
		platform3_height = Mathf.PingPong(Time.time * 4, 10*row3weight) + 36.43f;
	}
}
