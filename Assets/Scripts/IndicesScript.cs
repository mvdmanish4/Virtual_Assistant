using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IndicesScript : MonoBehaviour {
	public Rigidbody rb;
	public Camera cam;
	public Vector3 offset;
	// Use this for initialization
	void Start () {
		rb=GetComponent<Rigidbody>();
		//offset = cam.transform.position - rb.transform.position;
	}
	
	// Update is called once per frame
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
		if (col.CompareTag ("nasdaq"))
		{
			Debug.Log ("NASDAQ");
			Application.LoadLevel ("Level1Scene");
		} 
		else if (col.CompareTag ("s&p500")) 
		{
			Debug.Log ("S&P500");
			Application.LoadLevel ("Level1Scene");
		}
		else if (col.CompareTag ("cboe")) 
		{
			Debug.Log ("CBOE");
			Application.LoadLevel ("Level1Scene");
		}
	}

}
