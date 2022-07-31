using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraMovement : MonoBehaviour
{
    [SerializeField] private GameObject ball;
    private Vector3 offset;
    [SerializeField] private float lerpValue;
    void Start()
    {
        offset = transform.position - ball.transform.position;
    }

    
    void LateUpdate()
    {
        transform.position = Vector3.Lerp(transform.position, ball.transform.position + offset, lerpValue * Time.deltaTime);
        // transform.position = ball.transform.position + offset; // new Vector3()
    }
}
