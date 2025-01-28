using UnityEngine;
using UnityEngine.Assertions.Must;

public class SongGame : MonoBehaviour
{

    [SerializeField]
    private GameState state;

    public string[] songNotes = new string[8];

    public bool complete = false;

    // [SerializeField]
    // private GameObject notePrefab;

    // private GameObject[] noteObjects;

    // [SerializeField]
    // private Transform[] positions;

    [SerializeField]
    private GameObject noteSpawnReference;

    [SerializeField]
    private GameObject cameraReference;

    public void Initialize(string[] song)
    {
        songNotes = song;
    }

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {

        // NEW
        // Give details to noteSpawn
        NoteSpawn noteSpawn = noteSpawnReference.GetComponent<NoteSpawn>();
        noteSpawn.Initialize(songNotes);

        // Activate noteSpawn
        noteSpawnReference.SetActive(true);



        // ORIGINAL
        // Create song container
        // GameObject container = Instantiate(containerReference, transform);

        // Create note objects for song
        // noteObjects = new GameObject[songNotes.Length];

        // for( int i=0 ; i<songNotes.Length ; i++) {
        //     noteObjects[i] = Instantiate(noteReference);
            
        //     char noteName = songNotes[i];
        //     KeyCode key = getKey(noteName);

        //     Note noteObject = noteObjects[i].GetComponent<Note>();

        //     noteObject.note = noteName;
        //     noteObject.keybind = key;
        //     noteObject.transform.position = positions[i].position;

            // noteObject.transform.SetParent(container.transform, true);

            // Offset y depending on note value
            
            // X axis - move spawner to beginning of notes. for each note add i * gap to x position
        // }

        // Initate first note as active
        // noteObjects[0].GetComponent<Note>().active = true;

    }

    // Update is called once per frame
    // void Update()
    // {
    //    checkActive(); 
    // }

    // private KeyCode getKey(char note)
    // {
    //     if(note == 'c') {
    //         return KeyCode.A;
    //     }
    //     else if(note == 'a') {
    //         return KeyCode.S;
    //     }
    //     else if (note == 'b') {
    //         return KeyCode.D;
    //     }
    //     else {
    //         return KeyCode.Q;
    //     }
    // }

    // // Check active states
    // private void checkActive()
    // {
    //     bool prevNoteComplete = false;

    //     for( int i=0 ; i<noteObjects.Length ; i++) {
    //         Note noteObject = noteObjects[i].GetComponent<Note>();

    //         // check if note is complete
    //         if(!noteObject.active) {
    //             if(noteObject.complete) {
    //                 prevNoteComplete = true;
    //                 continue;
    //             }
                
    //             // Debug.Log("Note " + i + " is not active.");
    //             else {
    //                 if(prevNoteComplete) {
    //                     noteObject.active = true;
    //                 }
    //             }
    //         }
    //     }

    //     Note lastNote = noteObjects[noteObjects.Length-1].GetComponent<Note>();
    //     if(lastNote.complete) {
    //         complete = true;
    //         // GameplayCamera camera = cameraReference.GetComponent<GameplayCamera>();
    //         // camera.moveEnabled = true;
    //     }
    // }

}
