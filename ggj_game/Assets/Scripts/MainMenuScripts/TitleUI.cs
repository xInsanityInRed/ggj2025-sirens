using System;
using System.Data;
using UnityEngine;
using UnityEngine.UI;

public class TitleUI : MonoBehaviour
{
    [SerializeField]
    private GameObject playButtonReference;
    
    [SerializeField]
    private GameObject optionsButtonReference;

    [SerializeField]
    private GameObject exitButtonReference;

    [SerializeField]
    private GameController gameControllerReference;
    
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        // Set up play button
        Button playButton = playButtonReference.GetComponent<Button>();
        GameController gameController = gameControllerReference.GetComponent<GameController>();

        playButton.onClick.AddListener(delegate {
            gameController.startGame();
        });

        // Set up exit game
        Button exitButton = exitButtonReference.GetComponent<Button>();
        exitButton.onClick.AddListener(delegate {
            gameController.quitGame();
        });
    }

    // Update is called once per frame
    void Update()
    {
        
    } 
}
