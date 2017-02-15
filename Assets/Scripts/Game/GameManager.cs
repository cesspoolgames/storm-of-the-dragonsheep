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
    private static float levelTop;

    void Awake() {
        if (instance != null && instance != this) {
            Destroy(gameObject);
        }
        instance = this;

        levelLeft = Camera.main.ViewportToWorldPoint(new Vector2(0f, 0f)).x;
        levelRight = Camera.main.ViewportToWorldPoint(new Vector2(1f, 0f)).x;
        levelTop = Camera.main.ViewportToWorldPoint(new Vector2(0f, 1f)).y;
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

    public static float LevelTop {
        get {
            return levelTop;
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
