using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HeroHitArea : MonoBehaviour {

	void OnTriggerEnter2D(Collider2D other) {
		if (other.tag == "Enemy") {
			SheepAction sheepAction = other.gameObject.GetComponent<SheepAction>();
			sheepAction.Die();
		}
	}
}
