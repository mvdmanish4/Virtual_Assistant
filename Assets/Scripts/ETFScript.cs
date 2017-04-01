using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ETFScript : MonoBehaviour {
	
	void Start () {
		gameObject.GetComponent<Renderer> ().enabled = false;
	}

	void FixedUpdate () {
		float moveHorizontal = Input.GetAxis ("Horizontal");
		float moveVertical = Input.GetAxis ("Vertical");
		Vector3 movement = new Vector3 (moveHorizontal, 0.0f, moveVertical);
		GetComponent<Rigidbody> ().AddForce (movement * 2);
	}
	
	/*void OnCollisionEnter(Collision collision){
		gameObject.GetComponent<MeshRenderer> ().enabled = true;
	}*/

	void OnTriggerEnter(Collider col) {

		if (col.CompareTag ("StockExchange")) {
			Debug.Log ("Entered SE");
			Application.LoadLevel ("RollABaller");
			
		}
			//Handheld.PlayFullScreenMovie ("BLKvideo.mp4", Color.black, FullScreenMovieControlMode.CancelOnInput);
			//gameObject.GetComponent<Renderer> ().enabled = true;



	
	}


	void Update () {
		
	}
}
