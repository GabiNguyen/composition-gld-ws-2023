using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using StarterAssets;

public class Door : MonoBehaviour {

    private bool open = false;
    private bool changing = false;
    private bool inRange = false;

    private StarterAssetsInputs inputs;

    void Start() {
        inputs = FindObjectOfType<StarterAssetsInputs>();
    }

    void Update() {
        if (inRange && inputs.interact && !changing) {
            if (open) {
                StartCoroutine(Change(-140));
            } else {
                StartCoroutine(Change(140));
            }

            open = !open;
        }
    }

    public void OnTriggerEnter(Collider other) {
        inRange = true;
    }

    public void OnTriggerExit(Collider other) {
        inRange = false;
    }

    private IEnumerator Change(int degrees) {
        changing = true;
        for (int i = 0; i < 50; i++) {
            transform.Rotate(0, degrees / 50, 0);
            yield return new WaitForSeconds(0.01f);
        }
        changing = false;
        inputs.interact = false;
    }
}
