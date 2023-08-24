using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class paddleController : MonoBehaviour
{
    public KeyCode input;
    public Collider bola;

    //simpan angka target position 
    private float targetPressed;
    private float targetRelease;

    private Renderer renderer;
    private Animator animator;

    public audioManager audioManager;

	private HingeJoint hinge;

	private void Start()
    {
        hinge = GetComponent<HingeJoint>();
        targetPressed = hinge.limits.max;
        targetRelease = hinge.limits.min;

        renderer = GetComponent<Renderer>();
        animator = GetComponent<Animator>();
    }

	private void Update()
    {
        ReadInput(); // Read Input Here
    }

    private void ReadInput() // Move Paddle Here
    {
        JointSpring jointSpring = hinge.spring;

        if (Input.GetKey(input))
        {
            jointSpring.targetPosition = targetPressed;
        }
        else
        {
            jointSpring.targetPosition = targetRelease;
        }

        hinge.spring = jointSpring;
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.collider == bola)
        {
        animator.SetTrigger("hit");
        audioManager.PlaySFXPaddle(collision.transform.position);
        }
    }
}
