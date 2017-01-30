using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HeroVisual : MonoBehaviour {

    HeroMovement heroMovement;

    void Awake() {
        heroMovement = GetComponent<HeroMovement>();
    }

    void Update() {
        var horizontal = Input.GetAxisRaw("Horizontal");
        FlipXIfNeeded(horizontal);
        FlippyRotationIfNeeded();
    }

    void FlipXIfNeeded(float horizontal) {
        if (horizontal != 0f) {
            bool isGoingRight = horizontal > 0f;
            transform.localScale = new Vector2(isGoingRight ? 1f : -1f, 1f);
        }
    }

    void FlippyRotationIfNeeded() {
        if (heroMovement.IsFlipping()) {
            transform.rotation = Quaternion.Euler(new Vector3(0, 0, 90f));
        } else {
            transform.rotation = Quaternion.identity;
        }
    }

}
