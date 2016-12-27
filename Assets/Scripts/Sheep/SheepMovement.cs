using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SheepMovement : MonoBehaviour {

	public float moveForce = 40f;

	new Rigidbody2D rigidbody;
	SpriteRenderer spriteRenderer;

	void Awake() {
		rigidbody = GetComponent<Rigidbody2D>();
		spriteRenderer = GetComponent<SpriteRenderer>();
	}

	void Update() {
		DestoryIfOutOfScreen();
	}

	void DestoryIfOutOfScreen() {
		// If y is too down below...
		bool shouldDestroy = Camera.main.WorldToViewportPoint(transform.position).y < -0.5f;
		if (shouldDestroy) {
			Destroy(gameObject);
		}
	}

	void FixedUpdate() {
		var force = new Vector2(moveForce, 0);
		if (isGoingLeft()) {
			force *= -1;
		}
		rigidbody.AddForce(force);
	}

	public bool isGoingLeft() {
		return spriteRenderer.flipX == true;
	}

	public void FlipX() {
		spriteRenderer.flipX = !spriteRenderer.flipX;
	}
}
