using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Playables;
using UnityEngine.Events;

public class StartInteraction : MonoBehaviour
{
    public UnityEvent triggerDialogue;
    bool hitCollider = false;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.Q) && hitCollider) {
            triggerDialogue.Invoke();
        }
    }

    void OnTriggerEnter2D(Collider2D collision) {
        Debug.Log("You hit THEEE duck.");
        hitCollider = true;
    }
}
