using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObstacleSpawner : MonoBehaviour
{
    public GameObject obstacle;
    public Transform spawnPoint;

    public float distance;
    private float width;

    // Start is called before the first frame update
    void Start()
    {
        width = obstacle.GetComponent<BoxCollider2D>().size.x;
    }

    // Update is called once per frame
    void Update()
    {
        if(transform.position.x < spawnPoint.position.x)
        {
            transform.position = new Vector3(transform.position.x + width + distance, transform.position.y, transform.position.z);
            Instantiate(obstacle, transform.position, transform.rotation);
        }
    }
}
