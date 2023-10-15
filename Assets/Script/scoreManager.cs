using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class scoreManager : MonoBehaviour
{
    public float score;
	
    private void Start()
    {
        ResetScore();
    }

    public void AddScore(float addition)
    {
        // tambah skor berdasarkan parameter
        score += addition;
    }

    public void ResetScore()
    {
        // kembalikan skor ke 0 untuk situasi tertentu
        score = 0;
    }
}
