using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SheepMovement : MonoBehaviour {

	new Rigidbody2D rigidbody;
	BoxCollider2D boxCollider;

	void Awake() {
		rigidbody = GetComponent<Rigidbody2D>();
		boxCollider = GetComponent<BoxCollider2D>();
	}

	void FixedUpdate() {
		rigidbody.AddForceAtPosition(new Vector2(-5f, 0), new Vector2(boxCollider.bounds.size.x / 2f, 0));
	}
}
