using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class level3_marcopolo : MonoBehaviour {
    public Transform other;
    public Transform player;
    public float dist;
    public GameObject go;

    // Use this for initialization
    void Start () {
        go = GameObject.Find("marcopolo");
        dist = 999999f;
    }
	
	// Update is called once per frame
	void Update () {
		dist = Vector3.Distance(other.position, player.position);
        go.GetComponent<AudioSource>().volume = 0.5f;
    }
}
