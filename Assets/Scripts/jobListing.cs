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
        if (Input.GetKey(KeyCode.Q) && isPicked) {
            this.gameObject.SetActive(false);
        }
    }

    void OnMouseDown() 
    {
        runner.StartDialogue("newspaper");
        triggerInstruction.Invoke();
        isPicked = true;
    }
}
