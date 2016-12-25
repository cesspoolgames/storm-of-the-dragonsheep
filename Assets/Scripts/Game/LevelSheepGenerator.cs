using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using MovementEffects;

public class LevelSheepGenerator : MonoBehaviour {

	public float sheepGenerationDelay = 1.2f;

	// Use this for initialization
	void Start () {
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
		Debug.Log("HEY!" + Random.value);
	}

}
