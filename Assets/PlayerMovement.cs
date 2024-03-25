using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class PlayerMovement : MonoBehaviour
{
    public float moveSpeed = 5f;
    public Transform characterSprite; // Reference to your character's sprite (assign in the Inspector)

    private CharacterController characterController;

    private void Start()
    {
        characterController = GetComponent<CharacterController>();
    }

    private void Update()
    {
        float horizontalInput = Input.GetAxis("Horizontal");
        float verticalInput = Input.GetAxis("Vertical");

        Vector3 moveDirection = new Vector3(horizontalInput, verticalInput, 0f);
        moveDirection.Normalize();

        // Calculate rotation angle
        float angle = Mathf.Atan2(moveDirection.y, moveDirection.x) * Mathf.Rad2Deg;

        // Adjust the angle to match your sprite's initial orientation
        // (assuming your sprite faces up initially)
        angle -= 90f;

        // Rotate the character sprite
        characterSprite.rotation = Quaternion.Euler(0f, 0f, angle);

        // Move the character
        characterController.Move(moveDirection * moveSpeed * Time.deltaTime);
    }
}