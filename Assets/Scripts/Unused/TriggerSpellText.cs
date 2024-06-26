using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TriggerSpellText : MonoBehaviour
{
    public bool isDirections = false;

    private ClaimCollectible collectible;

    // Start is called before the first frame update
    void Awake() {
        // Disabling this script for now, re-enable to see how it looks like :D
        Destroy(gameObject);
        collectible = GetComponent<ClaimCollectible>();
        if (collectible) collectible.OnCollectibleClaimed += TriggerSpellText_OnCollectibleClaimed;
	}

    private void OnTriggerExit2D(Collider2D other) {
        if (other.gameObject.CompareTag("Player")) {
            collectible.Collect();
        }
    }

    private void TriggerSpellText_OnCollectibleClaimed() {
        if (isDirections) {
            Destroy(this.gameObject);
        }
    }
}
