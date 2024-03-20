using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Yarn.Unity;

public class dialogueManager : MonoBehaviour
{
    // Start is called before the first frame update
    public string currentNode;
    DialogueRunner runner;
    void Start()
    {
        currentNode = "Start";
        runner = FindObjectOfType<DialogueRunner>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void RunDialogue() {
        runner.StartDialogue(currentNode);
    }

    [YarnCommand("advance")]
    public void AdvanceNode(string newNode) {
        currentNode = newNode;
    }

}
