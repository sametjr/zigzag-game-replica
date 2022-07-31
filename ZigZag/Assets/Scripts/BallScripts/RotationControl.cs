using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotationControl : MonoBehaviour
{
    [SerializeField] private GameObject ballGraphics;
    [SerializeField] private float rotationSpeed;
    public void RotateBallForward(){
        ballGraphics.transform.Rotate(-Vector3.forward * rotationSpeed * Time.deltaTime, Space.World);
    }

    public void RotateBallRight(){
        ballGraphics.transform.Rotate(Vector3.right * rotationSpeed * Time.deltaTime, Space.World);
    }
}
