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
        // gameObject.AddComponent(this);
        director = timeLine.GetComponent<PlayableDirector>();
        director.stopped += OnPlayableDirector;
    }

    // Update is called once per frame
    void Update()
    { 
        if (!animationPlayedAlready && qPressed && Input.GetKey(KeyCode.Q)) {
            AnimationEnter();
            triggerDialogue.Invoke();
            // when the space is entered 
            if (Input.GetKey(KeyCode.Space)) {
                // go to a different timeline (different C# file)
                    // the sheet should show what we want to happen
                        // start a timeline
                        // move to the next line
            }
                // go to the next node and synchronize the timeline that's with it 
                // move to the next animation which has the dialogue boxes
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
        // call the second animation!
    }

}
