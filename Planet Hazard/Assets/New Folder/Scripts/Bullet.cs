using UnityEngine;
using System.Collections;

public class Bullet : MonoBehaviour {

	public float speed = 6F;


	void Start()
	{
		GetComponent<Rigidbody2D>().angularVelocity = speed;
	}
	void ScreenExit()
	{
		Destroy (gameObject);
	}

}
