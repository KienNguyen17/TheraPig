using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Playables;

public class TriggerEvent : MonoBehaviour
{
    public GameObject timeLine;
    public GameObject player;
    PlayableDirector director;

    CameraFollow cameraFollow;

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
        

    
        //get a reference to the pig
        // get the CameraFollow component
            // enabled as false before director plays
                // director.stopped (to reenable it)
            // reenable after playing 

        
    }
}
