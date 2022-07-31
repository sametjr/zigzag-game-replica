using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PointsCreator : MonoBehaviour
{
    [SerializeField] private GameObject pointsPrefab;
    [SerializeField] private GroundSpawner groundSpawner;

    private int oneInHowMuch = 3;

    public void GeneratePointsRandomly(GameObject lastGeneratedGround){
        if(Random.Range(0, oneInHowMuch) == 0){
            Instantiate(pointsPrefab, lastGeneratedGround.transform.position + Vector3.up, Quaternion.identity);
        }
    }
}
