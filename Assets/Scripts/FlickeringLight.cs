using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FlickeringLight : MonoBehaviour
{
    public bool flickering = false;
    public float timeDelay;

    void Update()
    {
        if (flickering == false)
        {
            StartCoroutine(FlickeringLights());
        }
    }
    IEnumerator FlickeringLights()
    {
        flickering = true;
        this.gameObject.GetComponent<Light>().enabled = false;
        timeDelay = Random.Range(0.01f, 0.2f);
        yield return new WaitForSeconds(timeDelay);
        this.gameObject.GetComponent<Light>().enabled = true;
        timeDelay = Random.Range(0.01f, 0.2f);
        yield return new WaitForSeconds(timeDelay);
        flickering = false;

    }
}
