using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.InputSystem;

public class KeybindingManager : MonoBehaviour
{

    public static KeybindingManager Instance;

    private Dictionary<string, KeyCode> keyMappings = new Dictionary<string, KeyCode>
    {
        { "C", KeyCode.Q},
        { "D", KeyCode.W},
        { "E", KeyCode.E},
        { "F", KeyCode.R},
        { "G", KeyCode.A},
    };

    private void Awake()
    {
        if(Instance != null) {
            Destroy(gameObject);
            return;
        }

        Instance = this;
        DontDestroyOnLoad(this);
    }
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
