using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bumperController : MonoBehaviour
{
    public Collider bola;
    // kecepatan bola setelah memantul
    public float multiplier; 

    //----------Score----------------
    public scoreManager ScoreManager;
    public float score;

    //----------Audio----------------
    public audioManager audioManager;

    //----------Effect---------------
    public VFXManager vfxManager;
    public Color color;
    private Renderer renderer;
    private Animator animator;

    private void Start()
    {
        renderer = GetComponent<Renderer>();
        animator = GetComponent<Animator>();

        renderer.material.color = color;
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.collider == bola)
        {
        Rigidbody bolaRig = bola.GetComponent<Rigidbody>();
        bolaRig.velocity *= multiplier;

        ScoreManager.AddScore(score);

        animator.SetTrigger("hit");
        audioManager.PlaySFX(collision.transform.position);
        vfxManager.PlayVFX(collision.transform.position);
        }
    }
}
