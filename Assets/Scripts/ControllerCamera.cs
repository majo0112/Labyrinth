using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ControllerCamera : MonoBehaviour
{

    public GameObject Player;
    public Vector3 Distance; 

    void Start()
    {
        Distance = transform.position - Player.transform.position;
    }

    
    void Update()
    {
        transform.position = Player.transform.position + Distance;
    }
}
