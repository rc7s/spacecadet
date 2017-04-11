using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class A1_SpawnPillars : MonoBehaviour {
	public float timer;
	public int pillarCount;
	public GameObject pillar01;
	public GameObject pillar02;
	public GameObject pillar03;
	public GameObject pillar04;
	public GameObject pillar05;
	public GameObject pillar06;
	// Use this for initialization
	void Start () {
		timer = 1.0f;
		pillarCount = 1;
	}
	
	// Update is called once per frame
	void Update () {
		timer -= Time.deltaTime;
	}

	public void spawnthem () {
		//timer -= Time.deltaTime;
		if(timer <= 0)
		{
			if(pillarCount == 1)
			{
				pillar01.SetActive(true);
			}
			if (pillarCount == 2)
			{
				pillar02.SetActive(true);
			}
			if (pillarCount == 3)
			{
				pillar03.SetActive(true);
			}
			if (pillarCount == 4)
			{
				pillar04.SetActive(true);
			}
			if (pillarCount == 5)
			{
				pillar05.SetActive(true);
			}
			if (pillarCount == 6)
			{
				pillar06.SetActive(true);
			}
			pillarCount += 1;
			timer = 0.5f;
			if (pillarCount > 6)
			{
				pillarCount = 0;
			}
		}
	}

	void OnTriggerStay(Collider other)
	{
		if (other.tag == "Player")
		{
			spawnthem();
		}

	}
}
