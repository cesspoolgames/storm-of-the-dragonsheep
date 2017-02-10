using UnityEngine;

public class VillagerLogic : MonoBehaviour {

	public float hpRecoverRate = 40.0f;

	float hp = 100.0f;

    bool fallen = false;

    public bool IsFallen {
        get {
            return fallen;
        }
    }

    public float HP {
        get {
            return hp;
        }
    }

    void OnCollisionEnter2D(Collision2D collision) {
        switch (collision.gameObject.tag) {
            case "Enemy":
                fallen = true;
                hp = 0;
                break;
            case "Fruit":
                handleFruitCollision(collision);
                break;
        }
    }

    void handleFruitCollision(Collision2D collision) {
        Destroy(collision.gameObject);
    }

    void OnTriggerStay2D(Collider2D collider) {
        if (collider.gameObject.tag != "Untagged") {
            Debug.Log(collider.gameObject.tag);
        }
        switch (collider.gameObject.tag) {
			case "PlayerTrigger":
                if (IsFallen) {
                    handleRevive();
                }
                break;
        }
    }

    void handleRevive() {
        hp += hpRecoverRate * Time.deltaTime;
        Debug.Log("revive!" + hp);
        if (hp >= 100.0f) {
            fallen = false;
        }
    }

    void OnTriggerExit2D(Collider2D collider) {
        switch (collider.gameObject.tag) {
            case "PlayerTrigger":
                if (IsFallen) {
                    hp = 0;
                }
                break;
        }
    }

}
