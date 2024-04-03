using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Playables;
using UnityEngine.Events;
using Yarn.Unity;

public class DialogueAnimation3 : MonoBehaviour
{
    public UnityEvent startAnimation, endAnimation;
    public GameObject timeLine;
    PlayableDirector director1;
    SpriteRenderer renderer;

    void Start()
    {
        director1 = timeLine.GetComponent<PlayableDirector>();
        director1.stopped += OnPlayableDirector;
        renderer = gameObject.GetComponent<SpriteRenderer>();
        // director2 = timeLine2.GetComponent<PlayableDirector>();
        // director2.stopped += OnPlayableDirector;
    }

    
    void Update()
    {
        
    }

    void OnPlayableDirector(PlayableDirector direct) {
        endAnimation.Invoke(); 
    }

    // [YarnCommand("Activate")]
    // public void ActivatePlayer() {
    //     gameObject.SetActive(true);
    // }

    [YarnCommand("PlayAnimation")]
    public void PlayAnimation() {
        startAnimation.Invoke();
        director1.Play();
        // director2.Play();
    }

    [YarnCommand("ActivateCharacter")]
    public void ActivateCharacter() {
        renderer.enabled = true;
    }

    [YarnCommand("DeactivateCharacter")]
    public void DeactivateCharacter() {
        renderer.enabled = false;
    }
}
