using UnityEngine;
using UnityEngine.Assertions.Must;

public class SongSpawn : MonoBehaviour
{

    public string songNotes = "cabd";

    public bool complete = false;

    [SerializeField]
    private GameObject noteReference;

    private GameObject[] noteObjects;

    [SerializeField]
    private Transform[] positions;

    [SerializeField]
    private GameObject cameraReference;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        // Create note objects for song
        noteObjects = new GameObject[songNotes.Length];
        Debug.Log("Length: " + songNotes.Length);

        for( int i=0 ; i<songNotes.Length ; i++) {
            noteObjects[i] = Instantiate(noteReference);
            
            char noteName = songNotes[i];
            KeyCode key = getKey(noteName);

            Note noteObject = noteObjects[i].GetComponent<Note>();

            noteObject.note = noteName;
            noteObject.keybind = key;
            noteObject.transform.position = positions[i].position;
        }

        // Initate first note as active
        noteObjects[0].GetComponent<Note>().active = true;

    }

    // Update is called once per frame
    void Update()
    {
       checkActive(); 
    }

    private KeyCode getKey(char note)
    {
        if(note == 'c') {
            return KeyCode.A;
        }
        else if(note == 'a') {
            return KeyCode.S;
        }
        else if (note == 'b') {
            return KeyCode.D;
        }
        else {
            return KeyCode.Q;
        }
    }

    // Check active states
    private void checkActive()
    {
        bool prevNoteComplete = false;

        for( int i=0 ; i<noteObjects.Length ; i++) {
            Note noteObject = noteObjects[i].GetComponent<Note>();

            // check if note is complete
            if(!noteObject.active) {
                if(noteObject.complete) {
                    prevNoteComplete = true;
                    continue;
                }
                
                // Debug.Log("Note " + i + " is not active.");
                else {
                    if(prevNoteComplete) {
                        noteObject.active = true;
                    }
                }
            }
        }

        Note lastNote = noteObjects[noteObjects.Length-1].GetComponent<Note>();
        if(lastNote.complete) {
            complete = true;
            GameplayCamera camera = cameraReference.GetComponent<GameplayCamera>();
            camera.moveEnabled = true;
        }
    }

}
