using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class RestartMenuController : MonoBehaviour
{
    [SerializeField] Canvas restartMenuCanvas;
    [SerializeField] Text restartMenuScoreText;
    [SerializeField] GameManager gameManager;
    public void ShowRestartMenu(){
        restartMenuScoreText.text = gameManager.GetScores().ToString();
        restartMenuCanvas.gameObject.SetActive(true);
    }
}
