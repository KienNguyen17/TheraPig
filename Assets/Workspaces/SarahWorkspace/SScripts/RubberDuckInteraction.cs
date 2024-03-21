using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RubberDuckInteraction : MonoBehaviour
{
    public Canvas interactedObject;
    // public Button yesButton;
    // public Button noButton;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        // if (Input.GetKey(KeyCode.Q)) {
        //     Debug.Log("Q has been clicked");
        //     interactedObject.enabled = false;
        // }
    }

    void OnTriggerEnter2D(Collider2D collision) {
        // Debug.Log("You hit the duck.");
        interactedObject.enabled = true;
        
    }

    void OnTriggerExit2D(Collider2D collision) {
        Debug.Log("exited");
        interactedObject.enabled = false;
    }
}
