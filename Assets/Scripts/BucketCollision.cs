using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;



public class BucketCollision : MonoBehaviour {
	public Rigidbody rb;
	public GameObject g;
	public GameObject o;

	void Start () {
		rb=GetComponent<Rigidbody>();
		//var go = gameObject.Find ("ETF");
		g=GameObject.Find("ETF");
		o = GameObject.Find ("ETFtext");
		g.GetComponent<Renderer> ().enabled = false;
		o.GetComponent<Renderer> ().enabled = false;
	}
	
	void FixedUpdate () {
		float moveHorizontal = Input.GetAxis ("Horizontal");
		float moveVertical = Input.GetAxis ("Vertical");
		Vector3 movement = new Vector3 (moveHorizontal, 0.0f, moveVertical);


			GetComponent<Rigidbody> ().AddForce (movement * 2);


	}

	void OnTriggerEnter(Collider other) {


		if(other.CompareTag("BLKishares"))
		{	
			
			Debug.Log ("BLKishares");

			//Handheld.PlayFullScreenMovie ("BLKvideo.mp4", Color.black, FullScreenMovieControlMode.CancelOnInput);
			GameObject.Find ("SecBasket") .SetActive (false);


			GameObject g=GameObject.Find("ETF");
			g.GetComponent<Renderer> ().enabled = true;
			o.GetComponent<Renderer> ().enabled = true;
		}

	}


	void Update () {
		transform.Translate (Input.acceleration.x, 0, -Input.acceleration.z);
	}
}
