using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    // Start is called before the first frame update
    [SerializeField] float vehicleSpeed, turnSpeed;
    [SerializeField] float horizontalInput, forwardInput;

    void Start() {
        
    }

    // Update is called once per frame
    void Update() {

        horizontalInput = Input.GetAxis("Horizontal");
        forwardInput   = Input.GetAxis("Vertical");

        transform.Translate(Vector3.forward * vehicleSpeed * forwardInput * Time.deltaTime);
        transform.Rotate(Vector3.up, turnSpeed * horizontalInput * Time.deltaTime);
        // transform.Translate(Vector3.right * turnSpeed * horizontalInput * Time.deltaTime);
    }
}
