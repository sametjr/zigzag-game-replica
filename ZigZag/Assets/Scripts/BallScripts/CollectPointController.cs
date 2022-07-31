using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollectPointController : MonoBehaviour
{
    [SerializeField] GameManager gameManager;
    [SerializeField] private int pointGainedFromOneCapsule = 5;
    private void OnTriggerEnter(Collider other){
        if(other.gameObject.CompareTag("Point")){
            gameManager.UpdateScore(pointGainedFromOneCapsule);
            Destroy(other.gameObject);
        }
    }
}
