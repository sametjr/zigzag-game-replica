using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallDataTransmitter : MonoBehaviour
{
    [SerializeField] private BallMovementController ballMovementController;

    public void SetBallDirection(){
        ballMovementController.ChangeBallDirection();
    }
}
