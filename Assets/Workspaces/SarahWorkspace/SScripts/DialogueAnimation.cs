using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Playables;
using UnityEngine.Events;
using Yarn.Unity;

public class DialogueAnimation : MonoBehaviour
{
    public UnityEvent startAnimation, secondAnimation, endAnimation;
    public GameObject timeLine;
    public GameObject player;
    PlayableDirector director;

    // Start is called before the first frame update
    void Start()
    {
        director = timeLine.GetComponent<PlayableDirector>();
        director.stopped += OnPlayableDirector;
    }

    // Update is called once per frame
    void Update()
    {
        // User input == Q
            // play the scenes and dialogue
    }

    void OnPlayableDirector(PlayableDirector direct) {
        endAnimation.Invoke(); 
    }

    [YarnCommand("animate")]
    void StartFirstAnimation() {
        // if (Input.GetKey(KeyCode.Q)) {
            startAnimation.Invoke();
            director.Play();    
        // }
    }

    // [YarnCommand("animate1")]
    // void StartSecondAnimation() {
    //     secondAnimation.Invoke();
    //     director.Play();
    // }
}
