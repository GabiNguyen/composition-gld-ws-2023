using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CandleLightFlicker : MonoBehaviour
{
    private Light candleLight;

    void Start()
    {
        candleLight = GetComponent<Light>();
        StartCoroutine(Flicker());
    }

    private IEnumerator Flicker()
    {
        while (true)
        {
            candleLight.intensity = Random.Range(0.5f, 1.0f);
            yield return new WaitForSeconds(Random.Range(0.025f, 0.1f));
        }
    }
}
