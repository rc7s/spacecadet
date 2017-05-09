using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class chickenmove : MonoBehaviour {
	public float ms;
	public float timer;
	public float timer2;
	public float rotateTimer;
	public float smooth = 1f;
	private Vector3 targetAngles;
	public bool forward;
	public bool backwards; 
	public Rigidbody rb;
	public float currentHeight;
	public bool loop;

	// Use this for initialization
	void Start () {
		ms = 0.3f;
		forward = true;
		backwards = false;
		loop = true;
	}

	// Update is called once per frame
	void Update () {

		//currentHeight = transform.position.y;

		//while (loop) {
			timer = 2.0f;
			rotateTimer = 2.0f;
			timer2 = 2.0f;

			if (timer >= 0) {
				timer -= Time.deltaTime;

				//if (forward) {
					transform.position += transform.forward * ms / 2;
				//}

			}

			if (timer <= 0) {
				rotateTimer -= Time.deltaTime;
				targetAngles = transform.eulerAngles + 180f * Vector3.up; // what the new angles should be
				transform.eulerAngles = Vector3.Lerp (transform.eulerAngles, targetAngles, smooth * Time.deltaTime / 2); // lerp to new angles
				/*if (rotateTimer <= 0) {
					timer = 4.0f;
					if (forward) {
						forward = false;
						backwards = true;
					}
					if (backwards) {
						backwards = false;
						forward = true;
					}
				}*/
			}

			if (timer2 < 0) {
				timer2 -= Time.deltaTime;
				transform.position -= transform.forward * ms / 2;
			}
		}
	//}

	/*void OnCollisionEnter(Collider other){
		if (other.tag == "floor") {
			transform.position = new Vector3(transform.position.x, currentHeight, transform.position.z);
		}
	}*/
}