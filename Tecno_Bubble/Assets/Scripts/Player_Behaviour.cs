using UnityEngine;
using System.Collections;

public class Player_Behaviour : MonoBehaviour {

	private float force;

	void Update () {
		//force = Input.acceleration.x;
		force = Input.GetAxis ("Horizontal");
		rigidbody2D.AddForce(new Vector2 (force * 10, 0));
	}
}
