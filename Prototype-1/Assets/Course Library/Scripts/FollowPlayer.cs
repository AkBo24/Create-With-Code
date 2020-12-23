using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowPlayer : MonoBehaviour
{
    [SerializeField] private GameObject vehicle;
    [SerializeField] private Vector3 camOffset;
    // [SerializeField] private float camOffset;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        // transform.position = new Vector3(vehicle.transform.position.x,7,vehicle.transform.position.z + camOffset);

        transform.position = vehicle.transform.position + camOffset;
    }
}