using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VillagerVisual : MonoBehaviour {

    VillagerLogic villagerLogic;

    void Awake() {
        villagerLogic = GetComponent<VillagerLogic>();
    }

    void Update() {
        if (villagerLogic.IsFallen()) {
            transform.rotation = Quaternion.Euler(0, 0, -90f);
            GetComponent<Animator>().enabled = false;
        } else {
            transform.rotation = Quaternion.Euler(0, 0, 0);
            GetComponent<Animator>().enabled = true;
        }
    }
}
