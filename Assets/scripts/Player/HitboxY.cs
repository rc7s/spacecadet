using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HitboxY : MonoBehaviour {
    public enum RotationAxes { MouseXAndY = 0, MouseX = 1, MouseY = 2 }
    public RotationAxes axes = RotationAxes.MouseXAndY;
    public float sensitivityX = 1F;
    public float sensitivityY = 1F;
    public float minimumX = -360F;
    public float maximumX = 360F;
    public float minimumY = -60F;
    public float maximumY = 60F;
    float rotationY = 0F;
    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        rotationY += Input.GetAxis("Mouse Y") * 1f;
        rotationY = Mathf.Clamp(rotationY, minimumY, maximumY);

        //
    }
}
