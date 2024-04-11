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
        Invoke("RunDialogue", 0.5f);
        DontDestroyOnLoad(this.gameObject);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void RunDialogue() {
        if (runner.IsDialogueRunning){
            runner.Stop();
        }
        runner.StartDialogue(currentNode);
    }

    public void RunNode(string node) {
        runner.StartDialogue(node);
    }

    [YarnCommand("advance")]
    public void AdvanceNode(string newNode) {
        currentNode = newNode;
    }

}
