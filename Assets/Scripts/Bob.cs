using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bob : MonoBehaviour
{
    public float amp;
    public float freq;
    private Vector3 startPosition;

    void Start()
    {
        startPosition = transform.position;
    }

    void Update()
    {
        float newY = startPosition.y + Mathf.Sin(Time.time * freq) * amp;

        transform.position = new Vector3(startPosition.x, newY, startPosition.z);
    }
}
