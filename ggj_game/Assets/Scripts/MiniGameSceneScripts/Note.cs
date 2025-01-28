using System.Data;
using UnityEngine;
using UnityEngine.InputSystem;

public class Note : MonoBehaviour
{

    public bool active = false;

    public bool complete = false;

    public bool incorrect = true;

    [SerializeField]
    private RuntimeAnimatorController A_Controller;

    [SerializeField]
    private RuntimeAnimatorController W_Controller;

    public string noteName = "A";
    public KeyCode keybind = KeyCode.A;

    // private Renderer rend;

    private Animator anim;

    public void Initialize(string noteName, KeyCode key, float yPosition)
    {
        this.noteName = noteName;
        keybind = key;

        Vector3 currentPosition = transform.localPosition;
        currentPosition.y = yPosition;


        transform.localPosition = currentPosition;
    }

    private void Awake()
    {
        anim = gameObject.GetComponent<Animator>();
    }

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        // active = true;
        // rend = GetComponent<Renderer>();
        // anim = gameObject.GetComponent<Animator>();

        // Choose correct animations
        switch (keybind) {
            case KeyCode.A:
                anim.runtimeAnimatorController = A_Controller;
                break;
            case KeyCode.W:
                anim.runtimeAnimatorController = W_Controller;
                break;
            default:
                anim.runtimeAnimatorController = A_Controller;
                break;
        }
    }

    // Update is called once per frame
    void Update()
    {
        // if (active && Input.GetKeyDown(keybind)) {
        //     // rend.material.color = Color.red;
        //     anim.SetBool("Pressed", true);
        //     complete = true;
        //     active = false;
        // }
        // check if incorrect keybind

        // Check keypress
        if(active && Input.anyKeyDown) {
            // Check if correct keypress
            if(Input.GetKeyDown(keybind)) {
                anim.SetBool("Pressed", true);
                complete = true;
                active = false;
            }
            else {
                incorrect = true;
            }
        }

    }

    public void resetNote()
    {
        active = false;
        complete = false;
        incorrect = false;
        this.anim.SetBool("Pressed", false);
    }

} // class
