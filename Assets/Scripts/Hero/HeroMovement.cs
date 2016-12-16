using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HeroMovement : MonoBehaviour {

	public float speed = 1f;

	new Rigidbody2D rigidbody;
	SpriteRenderer spriteRenderer;

	void Awake() {
		rigidbody = GetComponent<Rigidbody2D>();
		spriteRenderer = GetComponent<SpriteRenderer>();
	}

	void Update() {
		var h = Input.GetAxisRaw("Horizontal");
		var v = Input.GetAxisRaw("Vertical");
		FlipXIfNeeded(h);
	}

	void FlipXIfNeeded(float h) {
		bool isGoingRight = h > 0;
		if (h != 0) {
			spriteRenderer.flipX = isGoingRight;
		}
	}

	void FixedUpdate() {
		var h = Input.GetAxisRaw("Horizontal");
		var v = Input.GetAxisRaw("Vertical");
		var movement = new Vector2(h, v) * speed;
		rigidbody.MovePosition(rigidbody.position + movement * Time.deltaTime);
	}
}
