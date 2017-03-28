using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KillChimes : MonoBehaviour {
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
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
    void OnTriggerStay()
    {

        pillar01.SetActive(false);
        pillar02.SetActive(false);
        pillar03.SetActive(false);
        pillar04.SetActive(false);
        pillar05.SetActive(false);
        pillar06.SetActive(false);
        pillar07.SetActive(false);
        pillar08.SetActive(false);
        pillar09.SetActive(false);
        pillar10.SetActive(false);
        pillar11.SetActive(false);
        pillar12.SetActive(false);
    }
}
