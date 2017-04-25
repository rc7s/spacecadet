using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class a1_lampkill : MonoBehaviour {
	public float timer;
	// Use this for initialization
	void Start () {
		timer = 3.0f;
	}
	
	// Update is called once per frame
	void Update () {
		timer -= Time.deltaTime;
		if (timer <= 0f) {
			gameObject.SetActive (false);
			timer = 3.0f;
		}
	}
}
