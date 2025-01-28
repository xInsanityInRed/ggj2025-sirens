using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "GameState", menuName = "Scriptable Objects/GameState")]
public class GameState : ScriptableObject
{
    public int numDays;

    public Dictionary<string, KeyCode> keybindings = new Dictionary<string, KeyCode> {
        {"F#3", KeyCode.Q},
        {"G#", KeyCode.W},
        {"A", KeyCode.E},
        {"B", KeyCode.R},
        {"C#", KeyCode.A},
        {"D", KeyCode.S},
        {"E", KeyCode.D},
        {"F#4", KeyCode.F}
    };

    public Dictionary<string, float> noteVertPosition = new Dictionary<string, float> {
        {"F#3", -0.42f},
        {"G#", -0.27f},
        {"A", -0.12f},
        {"B", 0.014f},
        {"C#", 0.16f},
        {"D", 0.32f},
        {"E", 0.48f},
        {"F#4", 0.63f}
    };
}
