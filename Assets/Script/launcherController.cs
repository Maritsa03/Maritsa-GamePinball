using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class launcherController : MonoBehaviour
{
    public Collider bola; 
	public KeyCode input;

    public float maxTimeHold;
    public float maxForce;

    private Renderer renderer;
    private Animator animator;
    public Color color;

    private bool isHold;

    private void Start()
    {
        renderer = GetComponent<MeshRenderer>();
        animator = GetComponent<Animator>();

        renderer.material.color = color;
        isHold = false;
    }

    private void OnCollisionStay(Collision collision)
	{
		if (collision.collider == bola)
		{
			ReadInput(bola);
		}
	}
	
	private void ReadInput(Collider collider)
	{
		if (Input.GetKey(input))
		{
		    if (Input.GetKey(input) && !isHold)
            {
                StartCoroutine(StartHold(collider));
                animator.Play("launcherPress");
            }
		}
	}

    private IEnumerator StartHold(Collider collider)
    {
        isHold = true;

        float force = 0.0f;
        float timeHold = 0.0f;

        while (Input.GetKey(input))
        {
            force = Mathf.Lerp(0, maxForce, timeHold/maxTimeHold);

            yield return new WaitForEndOfFrame();
            timeHold += Time.deltaTime;
            animator.Play("launcherRealize");
        }

        collider.GetComponent<Rigidbody>().AddForce(Vector3.forward * force);
        isHold = false;
    }
}
