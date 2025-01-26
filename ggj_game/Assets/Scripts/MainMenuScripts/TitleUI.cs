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
        Button playButton = playButtonReference.GetComponent<Button>();
        GameController gameController = gameControllerReference.GetComponent<GameController>();

        playButton.onClick.AddListener(delegate {
            gameController.startGame();
        });
    }

    // Update is called once per frame
    void Update()
    {
        
    }

   
}
