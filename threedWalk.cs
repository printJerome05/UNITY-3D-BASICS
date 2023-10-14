using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class threedWalk : MonoBehaviour
{
	Rigidbody rb;
	[SerializeField] float walkSpeed = 5f;
	[SerializeField] float jumpForce = 5f;


    // code for no infinite jumping
  
    [SerializeField] Transform groundCheck;
    [SerializeField] LayerMask groundLayer;

	// Start is called before the first frame update
	void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

	// Update is called once per frame
	void Update()
	{
        float horizontalInput = Input.GetAxis("Horizontal");
        float VerticalInput = Input.GetAxis("Vertical");

        rb.velocity = new Vector3(horizontalInput * walkSpeed, rb.velocity.y, VerticalInput * walkSpeed);

        if (Input.GetButtonDown("Jump") && IsGrounded())
        {
            Debug.Log("IsJumping");
            rb.velocity = new Vector3(rb.velocity.x, jumpForce, rb.velocity.z);
        }
	}

    bool IsGrounded()
    {
        return Physics.CheckSphere(groundCheck.position, .1f, groundLayer);
    }

	
}
