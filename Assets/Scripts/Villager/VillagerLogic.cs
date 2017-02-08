using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VillagerLogic : MonoBehaviour {

    bool fallen = false;

    void OnCollisionEnter2D(Collision2D collision) {
        switch (collision.gameObject.tag) {
            case "Enemy":
                fallen = true;
                break;
            case "Fruit":
                handleFruitCollision(collision);
                break;
        }
    }

    void handleFruitCollision(Collision2D collision) {
        Destroy(collision.gameObject);
    }

    public bool IsFallen() {
        return fallen;
    }

}
