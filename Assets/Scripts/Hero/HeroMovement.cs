using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HeroMovement : MonoBehaviour {

	public float speed = 1f;

	new Rigidbody2D rigidbody;

	void Awake() {
		rigidbody = GetComponent<Rigidbody2D>();
	}

	void FixedUpdate() {
		var h = Input.GetAxisRaw("Horizontal");
		MoveHero(h);
	}

	void MoveHero(float h) {
		var velocity = rigidbody.velocity;
		velocity.x = h * speed;
		rigidbody.velocity = velocity;
	}
}
