using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using MovementEffects;

public class NormalLevelManager : MonoBehaviour {

	public GameObject sheep;
	public float sheepCreationDelay = 3f;

	// Use this for initialization
	void Start () {
		Timing.RunCoroutine(_SheepCreationLoop(), "spawn");
	}

	IEnumerator<float> _SheepCreationLoop() {
		while (true) {
			yield return Timing.WaitForSeconds(sheepCreationDelay);
			var newSheep = Instantiate(sheep);
		}
	}
}
