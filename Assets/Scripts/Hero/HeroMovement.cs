using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HeroMovement : MonoBehaviour {

	public float speed = 1f;

	Rigidbody2D rigidbody;

	void Awake() {
		rigidbody = GetComponent<Rigidbody2D>();
	}

	void FixedUpdate() {
		var h = Input.GetAxisRaw("Horizontal");
		var v = Input.GetAxisRaw("Vertical");
		var movement = new Vector2(h, v) * speed;
		rigidbody.MovePosition(rigidbody.position + movement * Time.deltaTime);
	}
}
