using System.Collections;
using UnityEngine;

public class SceneController : MonoBehaviour
{
    [SerializeField]
    private GameObject songSpawnerReference;

    [SerializeField]
    private GameObject cameraReference;

    [SerializeField]
    private GameObject dialogCanvasReference;

    public string song = "cc";

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
        // GameObject songSpawner = Instantiate(songSpawnerReference);
        // songSpawner.SetActive(false);
        // SongSpawn spawner = songSpawner.GetComponent<SongSpawn>();
        SongSpawn spawner = songSpawnerReference.GetComponent<SongSpawn>();
        spawner.Initialize(song);
        // songSpawner.SetActive(true);
        songSpawnerReference.SetActive(true);

        // wait until song is complete
        yield return new WaitUntil(() => spawner.complete);

        // Pan camera
        GameplayCamera camera = cameraReference.GetComponent<GameplayCamera>();
        camera.moveEnabled = true;


        // wait until move is finished
        yield return new WaitUntil(() => camera.moveFinished);

        // Start Dialogue sequence
        dialogCanvasReference.SetActive(true);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
