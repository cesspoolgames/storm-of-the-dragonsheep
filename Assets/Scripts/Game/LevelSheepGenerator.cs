using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using MovementEffects;

public class LevelSheepGenerator : MonoBehaviour {

    public float sheepGenerationDelay = 1.2f;
    public GameObject sheep;
    public float sheepOffscreenOffset = 1f;
    public float sheepMaxStartYOffset = 2f;

    // Use this for initialization
    void Start() {
        Timing.CallDelayed<IEnumerator<float>>(null, sheepGenerationDelay, _ => {
            Timing.RunCoroutine(_SheepGenerationLoop());
        });
    }

    // Update is called once per frame
    IEnumerator<float> _SheepGenerationLoop() {
        while (true) {
            CreateRandomSheep();
            yield return Timing.WaitForSeconds(sheepGenerationDelay);
        }
    }

    void CreateRandomSheep() {
        GameManager.EnemyStartPosition sheepStartPosition = GameManager.RandomEnemyStartPosition();
        Vector2 newPosition;

        newPosition.y = Random.value * sheepMaxStartYOffset;
        bool flipX = false;
        if (sheepStartPosition == GameManager.EnemyStartPosition.Left) {
            newPosition.x = GameManager.LevelLeft - sheepOffscreenOffset;
        } else {
            newPosition.x = GameManager.LevelRight + sheepOffscreenOffset;
            flipX = true;
        }

        var newSheep = Instantiate(sheep, newPosition, Quaternion.identity) as GameObject;
        newSheep.GetComponent<SpriteRenderer>().flipX = flipX;
    }

}
