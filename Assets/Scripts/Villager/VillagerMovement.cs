using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VillagerMovement : MonoBehaviour {

	public float speed = 1f;

	new Rigidbody2D rigidbody;

	void Awake() {
		rigidbody = GetComponent<Rigidbody2D>();
	}

	void FixedUpdate() {
		Vector2 tempVelocity = rigidbody.velocity;
		tempVelocity.x = speed;
		rigidbody.velocity = tempVelocity;
	}

}
