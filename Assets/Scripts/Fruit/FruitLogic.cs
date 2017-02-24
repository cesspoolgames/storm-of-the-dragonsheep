using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FruitLogic : MonoBehaviour {

    GameObject myVillager = null;

    public bool TakenByVillger(GameObject villager) {
        if (myVillager != null) {
            return false;
        }

        myVillager = villager;
        return true;
    }

    void Update() {
        if (myVillager != null) {
            transform.position = myVillager.transform.position;
        }
    }

}
