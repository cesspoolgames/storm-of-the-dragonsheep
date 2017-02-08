using UnityEngine;

public class SheepAction : MonoBehaviour {
	public void Die() {
		GetComponent<SheepMovement>().enabled = false;
		GetComponent<CapsuleCollider2D>().enabled = false;
		GetComponent<Animator>().SetTrigger("Die");
	}
}
