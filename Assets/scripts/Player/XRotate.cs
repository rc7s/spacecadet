using UnityEngine;
using System.Collections;

public class XRotate : MonoBehaviour {

	public enum RotationAxes { MouseXAndY = 0, MouseX = 1, MouseY = 2 }
	public RotationAxes axes = RotationAxes.MouseXAndY;
	public float sensitivityX = 1F;
	public float sensitivityY = 1F;
	public float minimumX = -360F;
	public float maximumX = 360F;
	public float minimumY = -60F;
	public float maximumY = 60F;
	float rotationY = 0F;
	void Update ()
	{
		
			transform.Rotate(0, Input.GetAxis("Mouse X") * 1f, 0);

	}

	void Start(){}
}
