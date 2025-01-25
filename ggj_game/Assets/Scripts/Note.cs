using UnityEngine;

public class Note : MonoBehaviour
{

    public bool active = false;

    public bool complete = false;

    public char note = 'c';
    public KeyCode keybind = KeyCode.A;

    private Renderer rend;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        // active = true;
        rend = GetComponent<Renderer>();
    }

    // Update is called once per frame
    void Update()
    {
        if (active && Input.GetKeyDown(keybind)) {
            Debug.Log("A key was pressed.");
            rend.material.color = Color.red;
            complete = true;
            active = false;
        }
    }
} // class
