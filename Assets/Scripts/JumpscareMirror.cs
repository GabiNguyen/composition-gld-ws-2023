using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class JumpscareMirror : MonoBehaviour
{
    public GameObject mask;
    public GameObject[] lights;

    private bool jumpscaring = false;

    public void OnTriggerEnter(Collider other) {
        if (!jumpscaring) {
            StartCoroutine(Jumpscare());
        }
    }

    private IEnumerator Jumpscare() {
        jumpscaring = true;
        setLights(false);
        mask.SetActive(true);
        yield return new WaitForSeconds(0.50f);
        setLights(true);
        yield return new WaitForSeconds(0.2f);
        setLights(false);
        mask.SetActive(false);
        yield return new WaitForSeconds(0.25f);
        setLights(true);
        jumpscaring = false;
    }

    private void setLights(bool active) {
        foreach (var light in lights) {
            light.SetActive(active);
        }
    }
}
