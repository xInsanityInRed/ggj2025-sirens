using System.Runtime.CompilerServices;
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

            note.Initialize(song[i], key, y);

            notes[i].SetActive(true);
            
        }

        // Set first note as active
        notes[0].GetComponent<Note>().active = true;
    }

    private KeyCode getKey(string noteName)
    {
        KeyCode key = state.keybindings[noteName];

        return key;
    }

    // Update is called once per frame
    void Update()
    {
        checkActive();
    }

    // Check active states for notes
    private void checkActive()
    {
        bool prevNoteComplete = false;
        int prevComplete = -1;

        for( int i=0 ; i<song.Length ; i++) {
            
            // Get note object
            Note noteObject = notes[i].GetComponent<Note>();

            if(noteObject.incorrect) {
                resetNotes();
            }
            // Check if note is completed
            else if(!noteObject.active) { // note is not active

                if(noteObject.complete) { // note is complete
                    
                    prevNoteComplete = true;
                    prevComplete = i;
                    continue;
                }
                else { // note is not complete
                    
                    if(prevNoteComplete && prevComplete == i-1) {

                        noteObject.active = true;
                        return;
                    }
                }
            }
        }

        // Check if last note is now complete
        Note lastNote = notes[notes.Length-1].GetComponent<Note>();
        if( lastNote.complete ) {
            SongGameReference.GetComponent<SongGame>().complete = true;
        }
    }

    private void resetNotes()
    {
        for(int i=0 ; i<song.Length ; i++) {
            Note noteObject = notes[i].GetComponent<Note>();

            noteObject.resetNote();
        }

        // Set first note active
        notes[0].GetComponent<Note>().active = true;
    }
}
