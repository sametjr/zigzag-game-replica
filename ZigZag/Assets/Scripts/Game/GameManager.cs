using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    private int scores = 0;
    [SerializeField] ScoreHandler scoreHandler;
    [SerializeField] RestartMenuController restartMenuController;

    public void UpdateScore(int score){
        scores += score;
        scoreHandler.UpdateScore(scores);
        Debug.Log(scores);
    }

    public void RestartGame(){
        
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        BallInputController.isFirstTouchDone = false;
    }

    public int GetScores(){
        return scores;
    }

    public void ShowRestartUI(){
        restartMenuController.ShowRestartMenu();
    }
}
