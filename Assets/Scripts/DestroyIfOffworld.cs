using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyIfOffworld : MonoBehaviour {
    void Update() {
        DestoryIfOutOfScreen();
    }

    void DestoryIfOutOfScreen() {
		if (Utils.IsOffworld(transform)) {
            Destroy(gameObject);
        }
    }
}
