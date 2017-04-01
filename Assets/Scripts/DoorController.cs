using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorController : MonoBehaviour {
	public Rigidbody rb;
	public Camera cam;
	public Vector3 offset;
	// Use this for initialization
	void Start () {

		rb=GetComponent<Rigidbody>();
	}

	void FixedUpdate () {
		float moveHorizontal = Input.GetAxis ("Horizontal");
		float moveVertical = Input.GetAxis ("Vertical");
		Vector3 movement = new Vector3 (moveHorizontal, 0.0f, moveVertical);
		rb.AddForce (movement * 10);
	}

	// Update is called once per frame
	void Update () {
		
	}

	void LateUpdate()
	{
		cam.transform.position = rb.transform.position + offset;
	}

	void OnTriggerEnter(Collider col)
	{
		if (col.CompareTag ("door1"))
		{
			Debug.Log ("Entered iShare");
			Application.LoadLevel ("Indices");
		} 
		else if (col.CompareTag ("door2")) 
		{
			Debug.Log ("Entered BLK");
			Application.LoadLevel ("Indices");
		}
	}


}
