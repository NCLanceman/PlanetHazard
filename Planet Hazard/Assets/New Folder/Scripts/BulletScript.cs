using UnityEngine;
using System.Collections;

public class BulletScript : MonoBehaviour {

	public int damage = 5;
	public int speed = 500;

	// Use this for initialization
	void Start () {
		GetComponent<Rigidbody2D> ().AddForce (transform.up * speed);

		//Destroys the game object after 10 seconds.
		Destroy (gameObject, 2f);
	}
}
