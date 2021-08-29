using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public string inputID;
    private float speed = 20.0f;
    private float turnspeed = 25.0f;
    private float horizontalinput;
    private float verticalinput;
    public Camera mainCamera;
    public Camera hoodCamera;
    public KeyCode switchKey;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        horizontalinput = Input.GetAxis("Horizontal"+inputID);
        verticalinput = Input.GetAxis("Vertical"+inputID);

        // We'll run the vehical forward
        //transform.Translate(0, 0, 1);
        transform.Translate(Vector3.forward*Time.deltaTime*speed*verticalinput);
        transform.Rotate(Vector3.up, Time.deltaTime * turnspeed * horizontalinput);
        if (Input.GetKeyDown(switchKey))
        {
            mainCamera.enabled = !mainCamera.enabled;
            hoodCamera.enabled = !hoodCamera.enabled;
        }
    }
}
