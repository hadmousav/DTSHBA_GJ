using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class PlayerMovement : MonoBehaviour
{
    public float moveSpeed = 5f;
    public Rigidbody2D rb;
    public Transform characterSprite; // Reference to your character's sprite (assign in the Inspector)
    [SerializeField] Animator realAnimator;
    [SerializeField] Animator acidAnimator;

    [SerializeField] Animator currentAnimator;
    Vector2 movement;
    bool isreal = true;
    private void Start()
    {
        currentAnimator= realAnimator.GetComponent<Animator>();
        acidAnimator.gameObject.SetActive(false);
    }
    private void Update()
    {
        movement.x = Input.GetAxis("Horizontal");
        movement.y = Input.GetAxis("Vertical");
        if (movement != Vector2.zero)
        {
            currentAnimator.SetFloat("Horizontal", movement.x);
            currentAnimator.SetFloat("Vertical", movement.y);
        }
        currentAnimator.SetFloat("Speed", movement.sqrMagnitude);
    }
    private void FixedUpdate()
    {

        rb.MovePosition(rb.position + movement.normalized * moveSpeed * Time.fixedDeltaTime);
        //Vector3 moveDirection = new Vector3(horizontalInput, verticalInput, 0f);
       // moveDirection.Normalize();

        // Calculate rotation angle
        //float angle = Mathf.Atan2(moveDirection.y, moveDirection.x) * Mathf.Rad2Deg;

        // Adjust the angle to match your sprite's initial orientation
        // (assuming your sprite faces up initially)
       // angle -= 90f;

        // Rotate the character sprite
        //characterSprite.rotation = Quaternion.Euler(0f, 0f, angle);

        // Move the character
        //characterController.Move(moveDirection * moveSpeed * Time.deltaTime);
    }
    public void ChangeAnimation()
    {
        if(isreal)
        {
            currentAnimator = acidAnimator.GetComponent<Animator>();
            realAnimator.gameObject.SetActive(false);
            acidAnimator.gameObject.SetActive(true);
            isreal= false;
        }
        else
        {
            currentAnimator = realAnimator.GetComponent<Animator>();
            realAnimator.gameObject.SetActive(true);
            acidAnimator.gameObject.SetActive(false);
            isreal = true;
        }
    }
}