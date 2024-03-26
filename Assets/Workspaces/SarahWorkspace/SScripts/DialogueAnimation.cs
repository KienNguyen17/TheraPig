using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Playables;
using UnityEngine.Events;
using Yarn.Unity;

public class DialogueAnimation : MonoBehaviour
{
    public UnityEvent startAnimation, endAnimation;
    public GameObject timeLine;
    public GameObject player;
    PlayableDirector director;
    bool qPressed;
    bool animationPlayedAlready = false;

    public UnityEvent triggerDialogue;
void Start()
    {
        director = timeLine.GetComponent<PlayableDirector>();
        director.stopped += OnPlayableDirector;
    }

    // Update is called once per frame
    void Update()
    { 
        // how to get it so the user can only see this particular animation once
        if (!animationPlayedAlready && qPressed && Input.GetKey(KeyCode.Q)) {
            AnimationEnter();
            triggerDialogue.Invoke();
            
        }
    }

    void OnTriggerEnter2D(Collider2D collision) {
        Debug.Log("You hit THE duck.");
        qPressed = true;
    }

    void OnPlayableDirector(PlayableDirector direct) {
        endAnimation.Invoke(); 
    }

    // Have the animation play first, then when the animation is done, play the next dialogue
    void AnimationEnter() {
        startAnimation.Invoke();
        director.Play();
        animationPlayedAlready = true;
        DialogueAnimation2.Invoke();
    }

}
