using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HeroAction : MonoBehaviour {

	HeroHitArea hitArea;

	void Awake() {
		hitArea = GetComponentInChildren<HeroHitArea>();
		hitArea.gameObject.SetActive(false);
	}

	public void HitStart() {
		Debug.Log("Hit start");
		hitArea.gameObject.SetActive(true);
	}

	public void HitEnd() {
		Debug.Log("Hit end");
		hitArea.gameObject.SetActive(false);
	}
}
