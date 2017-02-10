using UnityEngine;

public class VillagerVisual : MonoBehaviour {

    VillagerLogic villagerLogic;

    void Awake() {
        villagerLogic = GetComponent<VillagerLogic>();
    }

    void Update() {
        if (villagerLogic.IsFallen) {
            var angle = -90.0f * (1f - villagerLogic.NormalizedHP);
            transform.rotation = Quaternion.Euler(0, 0, angle);
            GetComponent<Animator>().enabled = false;
        } else {
            transform.rotation = Quaternion.Euler(0, 0, 0);
            GetComponent<Animator>().enabled = true;
        }
    }
}
