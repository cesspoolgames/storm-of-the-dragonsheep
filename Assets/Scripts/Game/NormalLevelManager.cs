﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using MovementEffects;

public class NormalLevelManager : MonoBehaviour {

	public enum EnemyStartPosition {
		Left,
		Right
	};

	private float levelLeft;
	private float levelRight;

	void Start () {
		levelLeft = Camera.main.ViewportToWorldPoint(new Vector2(0f, 0f)).x;
		levelRight = Camera.main.ViewportToWorldPoint(new Vector2(1f, 0f)).x;
	}

	public float GetLevelLeft() {
		return levelLeft;
	}

	public float GetLevelRight() {
		return levelRight;
	}

}
