// using System.Threading;
// using UnityEngine;

// public class pipespawner : MonoBehaviour

// {
//     public GameObject pipePrefab;
//     public float spawnTime = 2;
//     private float timer = 0;
//     public float heightOffset = 10;
//     public float deadZone = 0;
//     // Start is called once before the first execution of Update after the MonoBehaviour is created
//     void Start()
//     {
//         spawnPipe();
//     }

//     // Update is called once per frame
//     void Update()
//     {

//         if (timer < spawnTime){
//             timer += Time.deltaTime;
//         }
//         else{
//             spawnPipe();
//             timer = 0;
//         }
//         if (transform.position.x < deadZone){
//             Destroy(gameObject);
//             Debug.Log("Pipe Destroyed");
//         }
//     }

//     void spawnPipe(){
//         float lowestPoint = transform.position.y - heightOffset;
//         float highestPoint = transform.position.y + heightOffset;
//         Instantiate(pipePrefab,new Vector3(transform.position.x, Random.Range(lowestPoint,highestPoint),0), transform.rotation);

//     }
// }


using UnityEngine;

public class PipeSpawner : MonoBehaviour
{
    public GameObject pipePrefab;   // Prefab of the pipe
    public float spawnTime = 2f;   // Time between pipe spawns
    private float timer = 0f;      // Internal timer to track spawn intervals
    public float heightOffset = 10f; // Random height variation for pipe spawning

    void Update()
    {
        // Increment timer
        if (timer < spawnTime)
        {
            timer += Time.deltaTime;
        }
        else
        {
            // Spawn a new pipe and reset the timer
            SpawnPipe();
            timer = 0f;
        }
    }

    void SpawnPipe()
    {
        // Determine the random spawn height
        float lowestPoint = transform.position.y - heightOffset;
        float highestPoint = transform.position.y + heightOffset;

        // Spawn a new pipe at a random height
        Instantiate(pipePrefab, new Vector3(transform.position.x, Random.Range(lowestPoint, highestPoint), 0), Quaternion.identity);
    }
}
