using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HeroMovement : MonoBehaviour {

    public float speed = 1f;
    public float jumpVelocity = 5.1f;

    new Rigidbody2D rigidbody;
    Animator animator;

    private bool flipping = false;

    void Awake() {
        rigidbody = GetComponent<Rigidbody2D>();
        animator = GetComponent<Animator>();
    }

    void Update() {
        HandleAttack();
        HandleJump();
        HandleFlip();
        KeepOnScreenArea();
    }

    void HandleAttack() {
        var attackPressed = Input.GetButtonDown("Fire1");
        if (attackPressed) {
            animator.SetTrigger("Attack");
        }
    }

    void HandleJump() {
        var jumpPressed = Input.GetKeyDown(KeyCode.UpArrow);
        if (jumpPressed) {
            Vector3 newVelocity = rigidbody.velocity;
            newVelocity.y = jumpVelocity;
            rigidbody.velocity = newVelocity;
        }
    }

    void HandleFlip() {
        var flipPressed = Input.GetKeyDown(KeyCode.DownArrow);
        if (flipPressed) {
            flipping = true;
        }

        var layerMask = ~(1 << LayerMask.NameToLayer("Hero"));
        RaycastHit2D hit = Physics2D.Raycast(transform.position, new Vector2(0, -1f), 0.5f, layerMask);
        if (hit.collider != null) {
            flipping = false;
        }
    }

    void KeepOnScreenArea() {
        if (Utils.IsOffworld(transform)) {
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

    public bool IsFlipping() {
        return flipping;
    }

}
