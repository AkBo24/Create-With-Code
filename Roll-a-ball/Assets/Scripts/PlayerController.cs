using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerController : MonoBehaviour
{
    [SerializeField] float moveSpeed;

    private Rigidbody rb;
    private float moveX, moveY;

    // Start is called before the first frame update
    void Start() {
        rb = GetComponent<Rigidbody>();
    }

    void OnMove(InputValue movementValue) {
        Vector2 moveVec = movementValue.Get<Vector2>();
        Debug.Log(moveVec);


        moveX = moveVec.x;
        moveY = moveVec.y;
    }

    private void FixedUpdate() {
        Vector3 moveVec = new Vector3(moveX, 0f, moveY);

        rb.AddForce(moveVec * moveSpeed);
    }
}
