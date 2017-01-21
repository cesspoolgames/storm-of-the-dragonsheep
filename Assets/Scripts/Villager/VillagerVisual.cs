using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VillagerVisual : MonoBehaviour {

    VillagerMovement movementScript;

    void Awake() {
        movementScript = GetComponent<VillagerMovement>();
    }

    void Update() {
        if (movementScript.IsFallen()) {
            transform.rotation = Quaternion.Euler(0, 0, -90f);
        } else {
            transform.rotation = Quaternion.Euler(0, 0, 0);
        }
    }
}
