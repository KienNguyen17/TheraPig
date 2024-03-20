using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using Yarn.Unity;

public class interactive : MonoBehaviour
{
    SpriteRenderer renderer;
    public bool isInteractible;
    public UnityEvent triggerDialogue;
    // DialogueRunner runner;
    // public UnityEvent intoInventory;

    // Start is called before the first frame update
    void Start()
    {
        renderer = GetComponent<SpriteRenderer>();
        // runner = FindObjectOfType<DialogueRunner>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.Q)) {
            Debug.Log("Q has been clicked");
            PickedUp();
        }
    }

    void OnTriggerEnter2D(Collider2D collision) {
        renderer.color = new Color(1,1,1,0.3f);
        isInteractible = true;
    }

    void OnTriggerExit2D(Collider2D collision) {
        renderer.color = new Color(1,1,1,1);
        isInteractible = false;
    }

    void PickedUp() {
        if (isInteractible) {
            isInteractible = false;
            // runner.StartDialogue("Start");
            triggerDialogue.Invoke();
            renderer.enabled = false;
        }
    }
}
