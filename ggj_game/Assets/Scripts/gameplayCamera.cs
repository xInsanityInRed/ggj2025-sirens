using UnityEngine;

public class gameplayCamera : MonoBehaviour
{

    public bool musicGameComplete = false;

    public bool moveComplete = false;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        // When minigame is complete pan the camera to x=22.5

    }

    public void moveCamera()
    {
        Vector3 newPosition = new Vector3();
        newPosition.x = 22.5f;
        newPosition.y = 0;
        newPosition.z = -10f;

        float speed = 5f;

        transform.position = Vector3.MoveTowards(transform.position, newPosition, speed*Time.deltaTime);
    }
}
