using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour {
	public Rigidbody rb;
	public Camera cam;
	public Vector3 offset;
	void Start () {
		rb=GetComponent<Rigidbody>();
		//offset = cam.transform.position - rb.transform.position;
	}


	void FixedUpdate () {
		float moveHorizontal = Input.GetAxis ("Horizontal");
		float moveVertical = Input.GetAxis ("Vertical");
		Vector3 movement = new Vector3 (moveHorizontal, 0.0f, moveVertical);
		rb.AddForce (movement * 10);
	}

	void LateUpdate()
	{
		cam.transform.position = rb.transform.position + offset;
	}


	void OnTriggerEnter(Collider col)
	{
		if (col.CompareTag ("Quattro"))
		{
			Debug.Log ("Quattro");
			Application.LoadLevel ("Door");
		} 
		else if (col.CompareTag ("building2")) 
		{
			Debug.Log ("building2");
			Application.LoadLevel ("Door");
		}
	}


}
