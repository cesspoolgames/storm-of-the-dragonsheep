using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Utils {
	static public bool IsOffworld(Transform transform) {
		bool isOffworld = Camera.main.WorldToViewportPoint(transform.position).y < 0f;
		return isOffworld;
	}
}
