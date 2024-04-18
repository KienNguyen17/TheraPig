using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Yarn.Unity;
using UnityEngine.Events;
using UnityEngine.UI;
using TMPro;

public class jobListing : MonoBehaviour
{
    DialogueRunner runner;
    public UnityEvent triggerInstruction;
    public UnityEvent intoInventory;
    bool isPicked;
    // Start is called before the first frame update
    void Start()
    {
        runner = FindObjectOfType<DialogueRunner>();
        isPicked = false;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.Space) && isPicked) {
            intoInventory.Invoke();
            isPicked = false;
        }
    }

    void OnMouseDown() 
    {
        runner.StartDialogue("newspaper");
        triggerInstruction.Invoke();
        isPicked = true;
    }
}
