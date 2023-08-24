using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TriggerRampController : MonoBehaviour
{
    public float score;

    public Collider bola;
    public scoreManager ScoreManager;

    private void OnTriggerEnter(Collider other)
    {
        if (other == bola)
        {
            ScoreManager.AddScore(score);
        }
    }
}
