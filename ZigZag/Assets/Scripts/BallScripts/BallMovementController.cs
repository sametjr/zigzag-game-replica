using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallMovementController : MonoBehaviour
{
    private Rigidbody rb;
    public Vector3 ballDirection;
    [SerializeField] public float ballSpeed; 
    [SerializeField] private GameObject ballGFX;
    [SerializeField] private float rotationSpeed;
    [SerializeField] GameManager gameManager;
    [SerializeField] private RotationControl rotationControl;
    [HideInInspector] public static Material choosenMaterial;
    [SerializeField] private GamePouseMenu gamePouseMenu;

    void Start()
    {
        ballGFX.GetComponent<MeshRenderer>().material = choosenMaterial;
        rb = GetComponent<Rigidbody>();
    }

    
    void Update()
    {
        MoveBall();
        CheckBallFall();
        RotateBall();
    }

    private void RotateBall(){
        if(!BallInputController.isFirstTouchDone) return;

        if(ballDirection.x == 1){
            rotationControl.RotateBallForward();
            
        }else{
            rotationControl.RotateBallRight();
        }
    }
    

    public void ChangeBallDirection(){
        if(gamePouseMenu.isGamePaused) return;
        
        if(ballDirection.x == 1)
        {
            ballDirection = Vector3.forward;
        }
        else
        {
            ballDirection = Vector3.right;
        }
    }

    private void MoveBall(){
        transform.Translate(ballDirection * ballSpeed * Time.deltaTime);
    }

    private void CheckBallFall(){
        if(transform.position.y <= -10){
            gameManager.ShowRestartUI();
        }
    }



    
}
