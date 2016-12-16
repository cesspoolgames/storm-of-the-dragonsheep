using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HeroVisual : MonoBehaviour {
	SpriteRenderer spriteRenderer;

	void Awake() {
        spriteRenderer = GetComponent<SpriteRenderer>();
	}

	void Update() {
		var h = Input.GetAxisRaw("Horizontal");
		FlipXIfNeeded(h);
	}

	void FlipXIfNeeded(float h) {
		bool isGoingRight = h > 0;
		if (h != 0) {
			spriteRenderer.flipX = isGoingRight;
		}
	}

}
