using UnityEngine;
using UnityEngine.SceneManagement;

public class GameController : MonoBehaviour
{



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

        // Start scene
        SceneManager.LoadScene("MiniGameScene");
    }
}
