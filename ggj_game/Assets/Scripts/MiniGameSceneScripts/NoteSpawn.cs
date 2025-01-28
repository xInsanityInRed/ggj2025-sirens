using UnityEngine;

public class NoteSpawn : MonoBehaviour
{

    [SerializeField]
    private GameState state;

    [SerializeField]
    private GameObject[] notes;

    [SerializeField]
    private GameObject SongGameReference;

    public string[] song;

    public void Initialize(string[] song)
    {
        this.song = song;
    }

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        // Initialise each note
        for (int i=0 ; i<song.Length ; i++) {
            Note note = notes[i].GetComponent<Note>();

            // Get keybinding for this note
            KeyCode key = getKey(song[i]);

            // Get y position for the note
            float y = state.noteVertPosition[song[i]];
            Debug.Log("Note " + i + " y: " + y);

            note.Initialize(song[i], key, y);

            notes[i].SetActive(true);
            
        }
    }

    private KeyCode getKey(string noteName)
    {
        KeyCode key = state.keybindings[noteName];

        return key;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
