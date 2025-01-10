// using UnityEngine;

// public class ParentPipe : MonoBehaviour
// {
//     public float moveSpeed = 5;
//     // Start is called once before the first execution of Update after the MonoBehaviour is created
//     void Start()
//     {
        
//     }

//     // Update is called once per frame
//     void Update()
//     {
//         transform.position += Vector3.left * moveSpeed * Time.deltaTime;
//     }
// }



using UnityEngine;

public class ParentPipe : MonoBehaviour
{
    public float moveSpeed = 5f;       // Speed at which the pipe moves to the left
    public float deadZone = -89f;     // Position at which the pipe gets destroyed

    // Update is called once per frame
    void Update()
    {
        // Move the pipe to the left
        transform.position += Vector3.left * moveSpeed * Time.deltaTime;

        // Destroy the pipe if it moves out of bounds
        if (transform.position.x < deadZone)
        {
            Destroy(gameObject);
            Debug.Log("Pipe Destroyed");
        }
    }
}
