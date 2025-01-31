using System.Collections;
// using FMOD;
using UnityEngine;

public class SceneController : MonoBehaviour
{
    public GameState state;

    [SerializeField]
    private GameObject songSpawnerReference;

    [SerializeField]
    private GameObject songSpawnerReferenceTwo;

    [SerializeField]
    private GameObject cameraReference;

    [SerializeField]
    private GameObject dialogCanvasReference;

    public bool secondSong = false;

    public string song = "cc";

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {

        Debug.Log(state.numDays);

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

        // Destroy first spawner
        Destroy(spawner.gameObject);

        // Start Dialogue sequence
        dialogCanvasReference.SetActive(true);

        yield return new WaitUntil(() => secondSong);

        dialogCanvasReference.SetActive(false);

        Debug.Log("secondSong");
        // spawnSecondSong();
        Debug.Log("spawn second song");

        SongSpawn spawner2 = songSpawnerReferenceTwo.GetComponent<SongSpawn>();
        spawner2.Initialize(song);
        // songSpawner.SetActive(true);
        songSpawnerReferenceTwo.SetActive(true);

        yield return new WaitUntil(() => spawner2.complete);

        Destroy(spawner2.gameObject);

        dialogCanvasReference.SetActive(true);
    }

    public void spawnSecondSong()
    {
        Debug.Log("spawn second song");

        SongSpawn spawner2 = songSpawnerReferenceTwo.GetComponent<SongSpawn>();
        spawner2.Initialize(song);
        // songSpawner.SetActive(true);
        songSpawnerReference.SetActive(true);

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
