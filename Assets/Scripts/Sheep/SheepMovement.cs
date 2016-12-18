using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SheepMovement : MonoBehaviour {

	public float moveForce = 40f;

	new Rigidbody2D rigidbody;
	BoxCollider2D boxCollider;

	void Awake() {
		rigidbody = GetComponent<Rigidbody2D>();
		boxCollider = GetComponent<BoxCollider2D>();
	}

	void FixedUpdate() {
		rigidbody.AddForce(new Vector2(-moveForce, 0));
	}
}
