using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FlickeringLight : MonoBehaviour
{
    private Light lightComponent;
    private bool isFlickering = false;

    void Start() {
        lightComponent = GetComponent<Light>();
    }

    void Update()
    {
        if (!isFlickering) {
            StartCoroutine(Flicker());
        }
    }

    private IEnumerator Flicker() {
        isFlickering = true;
        yield return new WaitForSeconds(Random.Range(0.5f, 2.0f));
        lightComponent.enabled = false;

        yield return new WaitForSeconds(Random.Range(0.1f, 0.5f));
        lightComponent.enabled = true;
        isFlickering = false;
    }
}
