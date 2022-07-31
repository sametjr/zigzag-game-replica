using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GamePouseMenu : MonoBehaviour
{
    [SerializeField] private Canvas pauseMenu;
    [HideInInspector] public bool isGamePaused = false;
    void Update(){
        CheckForEscapeInput();
    }

    private void CheckForEscapeInput(){
        if(Input.GetKeyDown(KeyCode.Escape)){
            ToggleGamePaused();
        }
    }

    private void ToggleGamePaused(){
        if(isGamePaused){
            ContinueGame();
        }else{
            PauseGame();
        }
    }

    public void PauseGame(){
        isGamePaused = true;
        pauseMenu.gameObject.SetActive(true);
        Time.timeScale = 0;
    }

    public void ContinueGame(){
        isGamePaused = false;
        pauseMenu.gameObject.SetActive(false);
        Time.timeScale = 1;
    }
}
