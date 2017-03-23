using UnityEngine;
using System.Collections;


public class PlayerMove : MonoBehaviour {

	public Rigidbody rb;


	public float ms;
	public float airspd;
	public float wallspd;

	public float maxSpeed;//Replace with your max speed

	public bool isGrounded;
	public bool onWall;
    private int velcheck;

    public Vector3 shake;


	// Use this for initialization
	void Start () {

        rb = GetComponent<Rigidbody>();

	

		ms = 1500f;
		airspd = 6;
		wallspd = 11;
        maxSpeed = 50f;

        velcheck = 0;

        shake.x = 0f;
        shake.y = -0.05f;
        shake.z = 0f;

        
    }

	// Update is called once per frame
	void Update () {
        if (Input.GetKeyDown(KeyCode.Space) && isGrounded)
        {
            //rb.AddForce(Vector3.up * 2700);
        }
    }
    
	void FixedUpdate()
	{

        if (isGrounded)
        {
			
			if (Input.GetKey (KeyCode.W)) {
				//transform.position += transform.forward * Time.deltaTime * ms;

				rb.AddRelativeForce (Vector3.forward * ms);
//			} else {
//				rb.isKinematic = true;
			}
            if (Input.GetKey(KeyCode.A))
			{
                //transform.position += transform.right * -1 * Time.deltaTime * ms;
                rb.AddRelativeForce(Vector3.right * -ms);
            }
//			else {
//				rb.isKinematic = true;
//			}
            if (Input.GetKey(KeyCode.S))
			{
                //transform.position += transform.forward * -1 * Time.deltaTime * ms;
                rb.AddRelativeForce(Vector3.forward * -ms);
            }
//			else {
//				rb.isKinematic = true;
//			}
            if (Input.GetKey(KeyCode.D))
			{
                //transform.position += transform.right * Time.deltaTime * ms;
                rb.AddRelativeForce(Vector3.right * ms);
            }
			if (!Input.GetKey(KeyCode.W) && !Input.GetKey(KeyCode.A) && !Input.GetKey(KeyCode.S) && !Input.GetKey(KeyCode.D) )
			{
				rb.isKinematic = true;
			}
//			else {
//				rb.isKinematic = true;
//			}
			rb.isKinematic = false;

            velcheck += 1;

        }
        if (!isGrounded)
        {
            if (!onWall)
            {
                if (Input.GetKey(KeyCode.W))
                {
                    //transform.position += transform.forward * Time.deltaTime * ms;
                    rb.AddRelativeForce(Vector3.forward * airspd);
                }
                if (Input.GetKey(KeyCode.A))
                {
                    //transform.position += transform.right * -1 * Time.deltaTime * ms;
                    rb.AddRelativeForce(Vector3.right * -airspd);
                }
                if (Input.GetKey(KeyCode.S))
                {
                    //transform.position += transform.forward * -1 * Time.deltaTime * ms;
                    rb.AddRelativeForce(Vector3.forward * -airspd);
                }
                if (Input.GetKey(KeyCode.D))
                {
                    //transform.position += transform.right * Time.deltaTime * ms;
                    rb.AddRelativeForce(Vector3.right * airspd);
                }

                velcheck = 0;
            }
            if (onWall)
            {
                if (Input.GetKey(KeyCode.A))
                {
                    //transform.position += transform.right * -1 * Time.deltaTime * ms;
                    rb.AddRelativeForce(Vector3.right * -wallspd);
                }
                if (Input.GetKey(KeyCode.D))
                {
                    //transform.position += transform.right * Time.deltaTime * ms;
                    rb.AddRelativeForce(Vector3.right * wallspd);
                }
                rb.AddRelativeForce(Vector3.up * 25);
                rb.AddRelativeForce(Vector3.forward * 20);
                velcheck += 1;
            }

        }
        
        

        if (isGrounded)
        {
            if (velcheck > 1)
            {
                rb.velocity = rb.velocity.normalized;
            }
		}
        if (rb.velocity.magnitude > maxSpeed && onWall)
        {
            if (velcheck > 1)
            {
                rb.velocity = rb.velocity.normalized * maxSpeed;
            }
        }

        if (Input.GetMouseButton(0))
        {

            //Instantiate(gameObject, spawnReg, Quaternion.identity);
            //Destroy(gameObject);
        }
    }

	void OnCollisionStay (Collision collision)
	{
        
            if (collision.gameObject.tag == "floor")
            {
                // iTween.ShakePosition(gameObject, shake, 1); fix when colliding
                 isGrounded = true;
            }
            if (collision.gameObject.tag == "wall")
            {
                onWall = true;
            }

        if (collision.gameObject.tag == "tut")
        {

            

        }
        if (collision.gameObject.tag == "city")
        {

            //Instantiate(gameObject, spawnReg, Quaternion.identity);
            //spawn.Play();
            Destroy(gameObject);

        }

    }

	void OnCollisionExit (Collision collision)
	{
		if(collision.gameObject.tag == "floor"){
			isGrounded = false;
		}
		if(collision.gameObject.tag == "wall"){
			onWall = false;
		}
	}

    void OnTriggerEnter(Collider other)
    {
       // checkpointScript.TriggerEntered(other);
    }
}
