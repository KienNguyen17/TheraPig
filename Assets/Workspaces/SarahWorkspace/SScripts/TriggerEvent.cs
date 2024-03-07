using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Playables;

public class TriggerEvent : MonoBehaviour
{
    public GameObject timeLine;
    PlayableDirector director;

    // Start is called before the first frame update
    void Start()
    {
        director = timeLine.GetComponent<PlayableDirector>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnTriggerEnter2D(Collider2D collision) {
        Debug.Log("Something");
        director.Play();
    }

    void OnTriggerExit2D (Collider2D collision) {
        GetComponent<BoxCollider2D>().enabled = false;
    }
}
