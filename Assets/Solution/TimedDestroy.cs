using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TimedDestroy : MonoBehaviour
{
    public float timeToDestroy = 3.0f;
    private float created;

    void Start()
    {
        created = Time.timeSinceLevelLoad;
    }

    void Update()
    {
        float elapsed = Time.timeSinceLevelLoad - created;
        if (elapsed >= timeToDestroy)
        {
            Destroy(gameObject);
        }
    }
}
