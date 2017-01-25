﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VillagerMovement : MonoBehaviour {

    public float speed = 1f;
    bool fallen = false;

    new Rigidbody2D rigidbody;

    void Awake() {
        rigidbody = GetComponent<Rigidbody2D>();
    }

    void FixedUpdate() {
        if (!fallen) {
            Vector2 tempVelocity = rigidbody.velocity;
            tempVelocity.x = speed;
            rigidbody.velocity = tempVelocity;
        }
    }

    void Update() {
        if (Utils.IsOffworld(transform)) {
            Destroy(gameObject);
        }
    }

    void OnCollisionEnter2D(Collision2D collision) {
        if (collision.gameObject.tag == "Enemy") {
            fallen = true;
        }
    }

    public bool IsFallen() {
        return fallen;
    }

}