using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class scoreUIController : MonoBehaviour
{
    public TMP_Text scoreText;
	
    public scoreManager ScoreManager;

    private void Update()
    {
        scoreText.text = ScoreManager.score.ToString();
    }
}
