using UnityEngine;
using UnityEngine.SceneManagement;

public class GameController : MonoBehaviour
{

    public GameState state;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void startGame()
    {
        Debug.Log("GameStart");

        state.numDays = 4;

        // Start scene
        SceneManager.LoadScene("MiniGameScene");
    }

    public void quitGame()
    {
        #if UNITY_EDITOR
            Debug.Log("Quitting the game in the editor (this won't actually close the editor).");
            UnityEditor.EditorApplication.isPlaying = false; // Stops play mode in the editor
        #else
            Application.Quit(); // This will close the application in a build
            Debug.Log("Game is quitting...");
        #endif
    }
}
