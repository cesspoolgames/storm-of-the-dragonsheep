using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HeroMovement : MonoBehaviour {

	public float speed = 1f;

	new Rigidbody2D rigidbody;
	Animator animator;

	void Awake() {
		rigidbody = GetComponent<Rigidbody2D>();
		animator = GetComponent<Animator>();
	}

	void Update() {
		HandleAttack();
		KeepOnScreenArea();
	}

	void HandleAttack() {
		var attackPressed = Input.GetButtonDown("Fire1");
		if (attackPressed) {
            animator.SetTrigger("Attack");
        }
	}

	void KeepOnScreenArea() {
		bool isOffscreen = false;
		isOffscreen = Camera.main.WorldToViewportPoint(transform.position).y < 0f;
		if (isOffscreen) {
			// Back to action!
			var newPosition = Camera.main.ViewportToWorldPoint(new Vector2(0.5f, 1f));
			newPosition.z = transform.position.z;
			transform.position = newPosition;
		}
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
