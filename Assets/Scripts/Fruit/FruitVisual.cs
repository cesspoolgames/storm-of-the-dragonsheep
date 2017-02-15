using UnityEngine;

public class FruitVisual : MonoBehaviour {
    public void RandomizeImage() {
        SpriteRenderer renderer = GetComponentInChildren<SpriteRenderer>();
        renderer.sprite = GetRandomFruitSprite();
    }

    Sprite GetRandomFruitSprite() {
        Sprite[] sprites = (Sprite[])Resources.LoadAll<Sprite>("Images/nicefruit");
        var index = Random.Range(0, sprites.Length);
        return sprites[index];
    }
}
