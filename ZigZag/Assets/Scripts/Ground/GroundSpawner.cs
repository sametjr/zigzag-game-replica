using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GroundSpawner : MonoBehaviour
{
    [SerializeField] private GameObject groundPrefab;
    [SerializeField] private GameObject lastGroundPart;
    [SerializeField] private PointsCreator pointsCreator;
    private GameObject newGroundPart;

    void Start(){
        GenerateGrounds();
    }

    private void GenerateGrounds(){
        for(int i = 0; i < 50; i++){
            SpawnNewGround();
        }
    }

    public void SpawnNewGround(){
        var direction = Random.Range(0,2);
        var pos = lastGroundPart.transform.position;

        if(direction == 0){ // forward
            newGroundPart = Instantiate(groundPrefab, new Vector3(pos.x, pos.y, pos.z + 1f), Quaternion.identity);
        }else{ //right
            newGroundPart = Instantiate(groundPrefab, new Vector3(pos.x + 1f, pos.y, pos.z), Quaternion.identity);
        }
        
        
        lastGroundPart = newGroundPart;
        pointsCreator.GeneratePointsRandomly(lastGroundPart.gameObject);
    }

    public GameObject GetLastGroundPart(){
        return lastGroundPart;
    }

    public void SetLastGroundPart(GameObject movedGround){
        lastGroundPart = movedGround;
    }
    
}
