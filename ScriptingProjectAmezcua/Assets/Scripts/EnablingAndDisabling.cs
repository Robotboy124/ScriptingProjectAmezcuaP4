using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnablingAndDisabling : MonoBehaviour
{
    private Light light;

    private void Start()
    {
        light = GetComponent<Light>();
    }

    private void Update()
    {
        if (Input.GetKeyUp(KeyCode.Mouse0))
        {
            light.enabled = !light.enabled;
        }
    }
}
