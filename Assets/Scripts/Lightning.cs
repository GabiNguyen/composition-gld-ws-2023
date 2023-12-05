using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Lightning : MonoBehaviour
{
    public Light[] lights;
    private bool isFlickering = false;

    void Update()
    {
        if (!isFlickering) {
            StartCoroutine(Flicker());
        }
    }

    private IEnumerator Flicker() {
        isFlickering = true;
        yield return new WaitForSeconds(Random.Range(0.5f, 1f));
        foreach (Light light in lights) {
            light.enabled = false;
        }

        yield return new WaitForSeconds(Random.Range(0.2f, 0.6f));
        foreach (Light light in lights) {
            light.enabled = true;
        }

        yield return new WaitForSeconds(Random.Range(0.3f, 1f));
        foreach (Light light in lights) {
            light.enabled = false;
        }

        yield return new WaitForSeconds(Random.Range(0.5f, 0.8f));
        foreach (Light light in lights) {
            light.enabled = true;
        }

        yield return new WaitForSeconds(Random.Range(0.7f, 1.2f));
        foreach (Light light in lights) {
            light.enabled = false;
        }

        yield return new WaitForSeconds(Random.Range(3f, 8f));
        foreach (Light light in lights) {
            light.enabled = true;
        }

        isFlickering = false;
    }
}
