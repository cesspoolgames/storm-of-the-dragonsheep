using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HeroVisual : MonoBehaviour {
	SpriteRenderer spriteRenderer;

	void Awake() {
        spriteRenderer = GetComponent<SpriteRenderer>();
	}

	void Update() {
		var horizontal = Input.GetAxisRaw("Horizontal");
		FlipXIfNeeded(horizontal);
	}

	void FlipXIfNeeded(float horizontal) {
		if (horizontal != 0f) {
			bool isGoingRight = horizontal > 0f;
			transform.localScale = new Vector2(isGoingRight ? 1f : -1f, 1f);
		}
	}

}
