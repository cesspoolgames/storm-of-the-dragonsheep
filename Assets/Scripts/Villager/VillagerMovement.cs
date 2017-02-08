using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VillagerMovement : MonoBehaviour {

    public float speed = 1f;

    new Rigidbody2D rigidbody;

    VillagerLogic villagerLogic;

    void Awake() {
        rigidbody = GetComponent<Rigidbody2D>();
        villagerLogic = GetComponent<VillagerLogic>();
    }

    void FixedUpdate() {
        if (!villagerLogic.IsFallen()) {
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

}
