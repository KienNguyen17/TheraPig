using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Playables;
using UnityEngine.Events;

public class TriggerEvent : MonoBehaviour
{
    public UnityEvent startAnimation, endAnimation;
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
        
    }

    void OnTriggerEnter2D(Collider2D collision) {
        Debug.Log("Something");
        startAnimation.Invoke();
        director.Play();
    }

    void OnTriggerExit2D (Collider2D collision) {
        GetComponent<BoxCollider2D>().enabled = false;
    }

    void OnPlayableDirector(PlayableDirector direct) {
        endAnimation.Invoke(); 
    }

    
}
