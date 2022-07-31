using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyController : MonoBehaviour
{
    private GroundSpawner groundSpawner;
    [SerializeField] private PointsCreator pointsCreator;
    void Start()
    {
        groundSpawner = FindObjectOfType<GroundSpawner>();
    }
    private void OnCollisionExit(Collision other)
    {
        if (other.gameObject.CompareTag("Ball"))
        {
            StartCoroutine(AddRigidBodyToGroundPart());
        }
    }


    private IEnumerator AddRigidBodyToGroundPart()
    {
        yield return new WaitForSeconds(2);
        this.gameObject.AddComponent<Rigidbody>();
        yield return new WaitForSeconds(2);
        AddTheGroundToTheEnd();
    }

    private void AddTheGroundToTheEnd()
    {
        GameObject lastPart = groundSpawner.GetLastGroundPart();
        Destroy(this.gameObject.GetComponent<Rigidbody>());
        if (Random.Range(0, 2) == 0)
        {
            transform.position = new Vector3(lastPart.transform.position.x + 1,
                     lastPart.transform.position.y, lastPart.transform.position.z);
        }
        else
        {
            transform.position = new Vector3(lastPart.transform.position.x,
         lastPart.transform.position.y, lastPart.transform.position.z + 1);
        }

        groundSpawner.SetLastGroundPart(this.gameObject);
        pointsCreator.GeneratePointsRandomly(this.gameObject);
    }





}
