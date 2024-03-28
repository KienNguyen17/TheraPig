using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Playables;
using UnityEngine.Events;
using Yarn.Unity;

public class DialogueAnimation2 : MonoBehaviour
{
    public UnityEvent startAnimation, endAnimation;
    public GameObject timeLine, timeLine2;
    PlayableDirector director, director2;
    bool qPressed;
    // bool FirstAnimationPlayedAlready = false;
    // public string currentNode;
    // DialogueRunner runner;
    public UnityEvent triggerDialogue;

    // public UnityEvent triggerDialogue;
    // public string currentNode;
    void Start()
    {
        // currentNode = "StartKyle";

        director = timeLine.GetComponent<PlayableDirector>();
        director.stopped += OnPlayableDirector;
        director2 = timeLine2.GetComponent<PlayableDirector>();
        director2.stopped += OnPlayableDirector;

        // runner = FindObjectOfType<DialogueRunner>();
    }

    void Update()
    {
        if (Input.GetKey(KeyCode.Q) && qPressed) {
            StartFirstAnimation();
            // runner.StartDialogue(currentNode);
            triggerDialogue.Invoke();
            StartSecondAnimation();
            // if (currentNode == "StartNancy") {
                // StartSecondAnimation();
            // }
        }
    }

     void OnPlayableDirector(PlayableDirector direct) {
        endAnimation.Invoke(); 
    }

    void OnTriggerEnter2D(Collider2D collision) {
        Debug.Log("You hit THEEE duck.");
        qPressed = true;
    }

    // [YarnCommand("advance")]
    public void StartFirstAnimation() {
        startAnimation.Invoke();
        // runner.StartDialogue(currentNode);
        director.Play();
    }

    // [YarnCommand("advance")]
    // public void AdvanceNode(string newNode) {
    //     currentNode = newNode;
    // }

    [YarnCommand("advance")]
    public void StartSecondAnimation() {
        // Invoke("AdvanceNode", 0.5f);
        Debug.Log("In the second scene now");
        startAnimation.Invoke();
        director2.Play();
        // animationPlayedAlready = true;
        // triggerDialogue.Invoke();
    }
}
