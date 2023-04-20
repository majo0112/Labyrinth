using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ControllerPincho : MonoBehaviour
{
    public float maximumHeight = 1f;
    public float minimumHeight = 0;
    public float Velocity = 2f;
    private void Update()
    {
        float currentHeight = Mathf.PingPong(Time.time * Velocity, maximumHeight - minimumHeight) + minimumHeight;
        transform.localPosition = new Vector3(transform.localPosition.x, currentHeight, transform.localPosition.z);
    }
}
