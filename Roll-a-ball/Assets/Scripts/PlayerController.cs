using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;
using TMPro;

public class PlayerController : MonoBehaviour
{
    [SerializeField] float moveSpeed;
    [SerializeField] TextMeshProUGUI countText;
    [SerializeField] GameObject winTextObj;

    private Rigidbody rb;
    private float moveX, moveY;
    private float count;

    // Start is called before the first frame update
    void Start() {
        rb = GetComponent<Rigidbody>();
        
        count = 0;
        SetCountText();

        winTextObj.SetActive(false);
    }

    void SetCountText() {
        countText.text = "Count: " + count.ToString();

        if(count >= 3) 
            winTextObj.SetActive(true);
    }

    void OnMove(InputValue movementValue) {
        Vector2 moveVec = movementValue.Get<Vector2>();

        moveX = moveVec.x;
        moveY = moveVec.y;
    }

    private void FixedUpdate() {
        Vector3 moveVec = new Vector3(moveX, 0f, moveY);
        rb.AddForce(moveVec * moveSpeed);
    }

    private void OnTriggerEnter(Collider other) {
        if(other.gameObject.CompareTag("PickUps")) {
            other.gameObject.SetActive(false);
            count++;
            SetCountText();
        }
    }
}
