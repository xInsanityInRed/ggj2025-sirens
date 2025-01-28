using System.Data;
using UnityEngine;
using UnityEngine.InputSystem;

public class Note : MonoBehaviour
{

    public bool active = false;

    public bool complete = false;

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


    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        active = true;
        // rend = GetComponent<Renderer>();
        anim = gameObject.GetComponent<Animator>();

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
        if (active && Input.GetKeyDown(keybind)) {
            Debug.Log("A key was pressed.");
            // rend.material.color = Color.red;
            anim.SetBool("Pressed", true);
            complete = true;
            active = false;
        }
    }

    

} // class
