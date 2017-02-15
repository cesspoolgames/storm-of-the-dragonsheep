using System.Collections.Generic;
using UnityEngine;
using MovementEffects;

public class LevelFruitGenerator : MonoBehaviour {
    public float fruitGenerationDelay = 1.2f;
    public GameObject fruit;
    // Use this for initialization
    void Start() {
        Timing.CallDelayed<IEnumerator<float>>(null, fruitGenerationDelay, _ => {
            Timing.RunCoroutine(_FruitGenerationLoop());
        });
    }

    IEnumerator<float> _FruitGenerationLoop() {
        while (true) {
            CreateRandomFruit();
            yield return Timing.WaitForSeconds(fruitGenerationDelay);
        }
    }

    void CreateRandomFruit() {
        var newX = Random.Range(GameManager.LevelLeft, GameManager.LevelRight);
        var newY = GameManager.LevelTop;
        var newFruit = Instantiate(fruit, new Vector2(newX, newY), Quaternion.identity) as GameObject;
        newFruit.GetComponent<FruitVisual>().RandomizeImage();
    }
}
