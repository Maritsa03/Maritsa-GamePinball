using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Area : MonoBehaviour
{
    public Collider bola;
    public audioManager audioManager;
    private Animator animator;

    private void Start()
    {
        animator = GetComponent<Animator>();
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.collider == bola)
        {
            animator.SetTrigger("hit");
            audioManager.PlaySFXHit(collision.transform.position);
        }
    }
}
