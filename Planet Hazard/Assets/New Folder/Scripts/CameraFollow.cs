using UnityEngine;
using System.Collections;

public class CameraFollow : MonoBehaviour {

	private Vector3 playerTransform;
	private Vector3 playerVector;

	void Update () 
	{
		playerTransform = GameObject.Find ("Player").transform.position;

		playerVector = new Vector3 (playerTransform.x, playerTransform.y, -10);
		
		transform.position = new Vector3 (playerTransform.x, playerTransform.y, -10);
		
		
	}
}
