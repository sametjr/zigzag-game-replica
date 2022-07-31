using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class BallInputController : MonoBehaviour
{
    [SerializeField] BallDataTransmitter ballDataTransmitter;
    [SerializeField] BallMovementController ballMovementController;
    [SerializeField] GameManager gameManager;

    [SerializeField] private GamePouseMenu gamePouseMenu;
    [HideInInspector] public static bool isFirstTouchDone = false;
    void Update()
    {
        CheckForInput();
    }

    private void CheckForInput()
    {
        if (Input.GetMouseButtonDown(0))
        {
            isFirstTouchDone = true;
            ballDataTransmitter.SetBallDirection();
            ballMovementController.ballSpeed += 0.001f;
            if (transform.position.y >= 0 && !gamePouseMenu.isGamePaused)
            {
                gameManager.UpdateScore(1);
            }
        }
    }


}
