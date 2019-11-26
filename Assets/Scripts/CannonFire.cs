using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CannonFire : MonoBehaviour
{
    public GameObject cannon;
    public GameObject cannonBall;
    public GameObject spawnPointObj;
    public Vector3 spawnPoint;
    private Vector3 cannonAngle;
    private Vector3 ballAngle;
    private Rigidbody cannonballRb;
    //public float speed = 100.0f;

    public float speed { get; set; }

    public Text sliderValue;
    public Slider slider;

   
    // Start is called before the first frame update
    void Start()
    {
        
        
    }

    // Update is called once per frame
    void Update()
    {
        sliderValue.text = slider.value.ToString("0.0");

        if (Input.GetKeyDown("b"))
        {

            //Instantiate(cannonBall, new Vector3(1,1,-42), transform.rotation);
            
            
            
        }

        if (Input.GetKeyDown("space"))
        {
            //Testing spawn & shoot from off to the side of the cannon
            //GameObject cannonBallSpawn = Instantiate(cannonBall, new Vector3(1, 1, -42), cannonBall.transform.rotation) as GameObject;
            spawnPoint = spawnPointObj.transform.position;
            GameObject cannonBallSpawn = Instantiate(cannonBall, spawnPoint, cannon.transform.rotation) as GameObject;

            //cannonBallSpawn.transform.eulerAngles = (cannon.transform.forward);
            //cannonBall.transform.eulerAngles = cannonAngle;
            

            cannonBallSpawn.GetComponent<Rigidbody>().AddForce(transform.forward * speed, ForceMode.Impulse);


            Debug.Log("cannonAngle: " + cannonAngle);
            //Debug.Log("velocity of cannonBall: " + cannonballRb.velocity);
            Debug.Log("cannonball position: " + cannonBall.transform.position);
            Debug.Log("this is cannonballRb: " + cannonballRb);

        }
    }

    private void LateUpdate()
    {
        var ray = Camera.main.ScreenPointToRay(Input.mousePosition);

        cannon.transform.rotation = Quaternion.LookRotation(ray.direction, Vector3.up);
    }

    
}
