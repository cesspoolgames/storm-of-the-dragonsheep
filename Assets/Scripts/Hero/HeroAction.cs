using UnityEngine;

public class HeroAction : MonoBehaviour {

	HeroHitArea hitArea;

	void Awake() {
		hitArea = GetComponentInChildren<HeroHitArea>();
		hitArea.gameObject.SetActive(false);
	}

	public void HitStart() {
		hitArea.gameObject.SetActive(true);
	}

	public void HitEnd() {
		hitArea.gameObject.SetActive(false);
	}
}
