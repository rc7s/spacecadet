using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class a1_key2 : MonoBehaviour {
    public GameObject g1;
    public GameObject r1;
    public GameObject g2;
    public GameObject r2;
    public GameObject g3;
    public GameObject r3;
    public GameObject g4;
    public GameObject r4;
    public GameObject g5;
    public GameObject r5;
    public GameObject g6;
    public GameObject r6;
    public GameObject end;
    public int count;

    // Use this for initialization
    void Start () {
        count = 1;
	}
	
	// Update is called once per frame
	void Update () {
		if (count == 7)
        {
            end.SetActive(true);
        }
	}

    void OnTriggerStay(Collider other)
    {
        if (other.name == "y1")
        {
            if (count == 1)
            {
                g1.SetActive(true);
				count = 2;
            }
            else
            {
                r1.SetActive(true);
                count = 1;
            }
        }
        if (other.name == "y2")
        {
            if (count == 2)
            {
                g2.SetActive(true);
                count += 1;
            }
            else
            {
                r3.SetActive(true);
                count = 1;
            }
        }
        if (other.name == "y3")
        {
            if (count == 3)
            {
                g3.SetActive(true);
                count += 1;
            }
            else
            {
                r3.SetActive(true);
                count = 1;
            }
        }
        if (other.name == "y4")
        {
            if (count == 4)
            {
                g4.SetActive(true);
                count += 1;
            }
            else
            {
                r4.SetActive(true);
                count = 1;
            }
        }
        if (other.name == "y5")
        {
            if (count == 5)
            {
                g5.SetActive(true);
                count += 1;
            }
            else
            {
                r5.SetActive(true);
                count = 1;
            }
        }
        if (other.name == "y6")
        {
            if (count == 6)
            {
                g6.SetActive(true);
                count += 1;
            }
            else
            {
                r6.SetActive(true);
                count = 1;
            }
        }
    }
}
