using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour
{
    public GameObject cannon;
    public GameObject cannonBall;
    private Vector3 offsetCannon;
    private Vector3 offsetCannonBall;
    public bool ballActive = false;
    public CannonFire cf;
    public Vector3 cbPosition;

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
        if (GameObject.FindGameObjectsWithTag("cannonball").Length <=1)
        {
            //Fix This!
            //cbPosition = cf.cannonBallSpawn.transform.position;
            transform.position = cbPosition + offsetCannonBall;
            Debug.Log("in the if, ballActive: " + ballActive);
        }

        Debug.Log("ballActive: " + ballActive);
    }
}
