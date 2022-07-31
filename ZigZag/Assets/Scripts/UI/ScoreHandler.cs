using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreHandler : MonoBehaviour
{
    [SerializeField] private Text scoreText;
    public void UpdateScore(int score){
        scoreText.text = score.ToString();
    }
}
