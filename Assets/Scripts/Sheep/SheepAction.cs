using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SheepAction : MonoBehaviour {
	public void Die() {
		GetComponent<SheepMovement>().gameObject.SetActive(false);
	}
}
