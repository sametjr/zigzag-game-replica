using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class BallStartingMaterial : MonoBehaviour
{
    [SerializeField] private Material golfMaterial, greenMaterial, standartMaterial;
    [SerializeField] private Image startingImage;

    void Start(){
        startingImage.rectTransform.sizeDelta = new Vector2(Screen.width, Screen.height);
    }
    public void SetGolfMaterial(){
        BallMovementController.choosenMaterial = golfMaterial;
        StartGame();
    }

    public void SetGreenMaterial(){
        BallMovementController.choosenMaterial = greenMaterial;
        StartGame();
    }

    public void SetStandartMaterial(){
        BallMovementController.choosenMaterial = standartMaterial;
        StartGame();
    }

    private void StartGame(){
        SceneManager.LoadScene("SampleScene");
    }


}
