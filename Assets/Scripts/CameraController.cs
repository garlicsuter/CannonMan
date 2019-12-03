using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour
{
    public GameObject cannon;
    public GameObject cannonBall;
    private Vector3 offsetCannon;
    private Vector3 offsetCannonBall;
    // Start is called before the first frame update
    void Start()
    {
        offsetCannon = transform.position - cannon.transform.position;
        offsetCannonBall = transform.position - cannonBall.transform.position;
    }

    // Update is called once per frame
    void LateUpdate()
    {
        transform.position = cannon.transform.position + offsetCannon;
    }
}
