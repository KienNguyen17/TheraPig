using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Playables;
using UnityEngine.Events;
using Yarn.Unity;

public class DialogueAnimation2 : MonoBehaviour
{
    public UnityEvent startAnimation, endAnimation;
    public GameObject timeLine;
    public GameObject player;
    PlayableDirector director;
    bool qPressed;
    bool animationPlayedAlready = false;

    public UnityEvent triggerDialogue;
    
    // Start is called before the first frame update
    void Start()
    {
        director = timeLine.GetComponent<PlayableDirector>();
        director.stopped += OnPlayableDirector;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.Q) && animationPlayedAlready) {
            StartSecondAnimation();
            triggerDialogue.Invoke();
        }
    }
    
     void OnPlayableDirector(PlayableDirector direct) {
        endAnimation.Invoke(); 
    }

    // [YarnCommand("animate1")]
    public void StartSecondAnimation() {
        startAnimation.Invoke();
        director.Play();
        animationPlayedAlready = true;
    }
}
