using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour {

    private static GameManager instance;

    public static GameManager Instance {
        get {
            return instance;
        }
    }

    public enum EnemyStartPosition {
        Left,
        Right
    };

    private static float levelLeft;
    private static float levelRight;

    void Awake() {
        if (instance != null && instance != this) {
            Destroy(gameObject);
        }
        instance = this;

        levelLeft = Camera.main.ViewportToWorldPoint(new Vector2(0f, 0f)).x;
        levelRight = Camera.main.ViewportToWorldPoint(new Vector2(1f, 0f)).x;
    }

    public static float LevelLeft {
        get {
            return levelLeft;
        }
    }

    public static float LevelRight {
        get {
            return levelRight;
        }
    }


    public static EnemyStartPosition RandomEnemyStartPosition() {
        if (Random.value > 0.5f) {
            return EnemyStartPosition.Left;
        } else {
            return EnemyStartPosition.Right;
        }
    }

}
