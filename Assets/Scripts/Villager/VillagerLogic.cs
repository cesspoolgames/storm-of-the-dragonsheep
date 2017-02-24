using UnityEngine;

public class VillagerLogic : MonoBehaviour {

	public float hpRecoverRate = 40.0f;

    const float maxHp = 100.0f;
	float hp = maxHp;

    bool fallen = false;

    private GameObject myFruit = null;

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

    public float NormalizedHP {
        get {
            return hp / maxHp;
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
        GameObject fruit = collision.gameObject;
        bool taken = fruit.GetComponent<FruitLogic>().TakenByVillger(gameObject);
        if (taken) {
            myFruit = fruit;
        }
    }

    void OnTriggerStay2D(Collider2D collider) {
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
