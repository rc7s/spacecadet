using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Level1_p0fin : MonoBehaviour
{
    public GameObject walls;
    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    void OnCollisionEnter(Collision col)
    {
        if (col.gameObject.name == "key001")
        {
            Destroy(walls);
            Destroy(col.gameObject);
        }
    }
}
