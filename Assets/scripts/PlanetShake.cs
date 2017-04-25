using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlanetShake : MonoBehaviour {
    public Vector3 shake;
	// Use this for initialization
	void Start () {
        shake.x = 2f;
        shake.y = 2f;
        shake.z = 2f;
	}
	
	// Update is called once per frame
	void Update () {
        iTween.ShakeScale(gameObject,shake, 5f);

    }
}
