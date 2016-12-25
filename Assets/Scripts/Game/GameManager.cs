using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour {

	protected GameManager instance;

	public enum EnemyStartPosition {
		Left,
		Right
	};

	private static float levelLeft;
	private static float levelRight;

	void Awake() {
		if (instance) {
			return;
		}

		instance = new GameManager();
		levelLeft = Camera.main.ViewportToWorldPoint(new Vector2(0f, 0f)).x;
		levelRight = Camera.main.ViewportToWorldPoint(new Vector2(1f, 0f)).x;
	}

	public static float GetLevelLeft() {
		return levelLeft;
	}

	public static float GetLevelRight() {
		return levelRight;
	}

}
