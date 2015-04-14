using UnityEngine;
using System.Collections;

public class PlayerShooting : MonoBehaviour {

	public GameObject weaponShot;
	public Transform gun;
	public float fireRate;
	/*private PlayerAnimations facing;*/
	private float nextFire;


/*
	void Awake(){
		facing = GetComponent<PlayerAnimations>();
	}
*/
	void Update(){
		gunRotate ();

		if (Input.GetButton("Fire1") && Time.time > nextFire)
		{
			nextFire = Time.time + fireRate;
			shoot ();
		}

	}

	void gunRotate(){

		var mousePosition = Camera.main.ScreenToWorldPoint (Input.mousePosition);
		/*
		string face = facing.face;

		if (face == "Up") {
			gun.rotation = Quaternion.Euler (0,0,0);
		} else if (face == "Down") {
			gun.rotation = Quaternion.Euler (0,0,180);
		} else if (face == "Left") {
			gun.rotation = Quaternion.Euler (0,0,90);
		} else if (face == "Right") {
			gun.rotation = Quaternion.Euler (0,0,-90);
		}
		*/

		//Quaternion rot = Quaternion.LookRotation (transform.position - mousePosition,
		    //                                     Vector3.forward);

		gun.rotation = Quaternion.Euler (0, 0, transform.eulerAngles.z);
	}

	void shoot(){
		Instantiate (weaponShot, gun.position, gun.rotation);
	}

}
