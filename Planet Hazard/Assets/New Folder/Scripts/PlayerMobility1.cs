using UnityEngine;
using System.Collections;

public class PlayerMobility1 : MonoBehaviour {

	public float speed;
	public GameObject bullet;



	void FixedUpdate()
	{
		var mousePosition = Camera.main.ScreenToWorldPoint (Input.mousePosition);
		
		Quaternion rot = Quaternion.LookRotation (transform.position - mousePosition,
		                                          Vector3.forward);
		
		transform.rotation = rot;
		transform.eulerAngles = new Vector3 (0, 0, transform.eulerAngles.z);

		float moveVertical = Input.GetAxis ("Vertical");
		float moveHorizontal = Input.GetAxis ("Horizontal");

		Vector2 movement = new Vector2 (moveHorizontal, moveVertical);

		GetComponent<Rigidbody2D> ().AddForce (movement * speed);
	}
}
