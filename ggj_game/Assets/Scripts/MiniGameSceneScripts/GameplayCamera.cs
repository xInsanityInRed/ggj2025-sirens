using System.Numerics;
using UnityEngine;
using UnityEngine.UIElements;

public class GameplayCamera : MonoBehaviour
{

    public bool musicGameComplete = false;

    public bool moveEnabled = false;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        // When minigame is complete pan the camera to x=22.5
        if(moveEnabled) {
            moveCamera();
        }
    }

    public void moveCamera()
    {
        UnityEngine.Vector3 newPosition = new UnityEngine.Vector3();
        newPosition.x = 19.5f;
        newPosition.y = 0;
        newPosition.z = -10f;

        float speed = 5f;

        transform.position = UnityEngine.Vector3.MoveTowards(transform.position, newPosition, speed*Time.deltaTime);

        if(UnityEngine.Vector3.Distance(transform.position, newPosition) < 0.01f){
            moveEnabled = false;
        }
    }
}
