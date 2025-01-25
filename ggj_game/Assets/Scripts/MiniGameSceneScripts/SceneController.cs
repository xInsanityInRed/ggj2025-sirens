using System.Collections;
using UnityEngine;

public class SceneController : MonoBehaviour
{
    [SerializeField]
    private GameObject songSpawnerReference;

    [SerializeField]
    private GameObject cameraReference;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        StartCoroutine(startEvents());
    }

    IEnumerator startEvents()
    {
        // Wait a few seconds before starting song
        yield return new WaitForSeconds(3f);

        // Create the song spawner
        GameObject songSpawner = Instantiate(songSpawnerReference);
        SongSpawn spawner = songSpawner.GetComponent<SongSpawn>();

        // wait until song is complete
        yield return new WaitUntil(() => spawner.complete);

        // Pan camera
        GameplayCamera camera = cameraReference.GetComponent<GameplayCamera>();
        camera.moveEnabled = true;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
