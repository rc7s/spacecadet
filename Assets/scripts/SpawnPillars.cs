using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnPillars : MonoBehaviour {
    public float timer;
    public int pillarCount;
    public GameObject pillar01;
    public GameObject pillar02;
    public GameObject pillar03;
    public GameObject pillar04;
    public GameObject pillar05;
    public GameObject pillar06;
    public GameObject pillar07;
    public GameObject pillar08;
    public GameObject pillar09;
    public GameObject pillar10;
    public GameObject pillar11;
    public GameObject pillar12;
    // Use this for initialization
    void Start () {
        timer = 0.5f;
        pillarCount = 1;
	}

    // Update is called once per frame

    private void Update()
    {
        timer -= Time.deltaTime;
    }
    // Update is called once per frame
	// Update is called once per frame
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
            if (pillarCount == 7)
            {
                pillar07.SetActive(true);
            }
            if (pillarCount == 8)
            {
                pillar08.SetActive(true);
            }
            if (pillarCount == 9)
            {
                pillar09.SetActive(true);
            }
            if (pillarCount == 10)
            {
                pillar10.SetActive(true);
            }
            if (pillarCount == 11)
            {
                pillar11.SetActive(true);
            }
            if (pillarCount == 12)
            {
                pillar12.SetActive(true);
            }
            pillarCount += 1;
            timer = 0.5f;
            if (pillarCount > 12)
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
