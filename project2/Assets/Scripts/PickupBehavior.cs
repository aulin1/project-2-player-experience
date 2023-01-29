using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PickupBehavior : MonoBehaviour
{
    private Vector3 pos; 

    // Start is called before the first frame update
    void Start()
    {
        pos = transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        float t = (Mathf.Sin(Time.time) + 1)/2;

        Vector3 offset = Vector3.up;
        transform.position = Vector3.Lerp(pos + (Vector3.up * 0.1f), pos + offset, t);
    }
}
