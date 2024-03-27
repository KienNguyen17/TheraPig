using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using Yarn.Unity;
using UnityEngine.UI;
using TMPro;

public class interactive : MonoBehaviour
{
    SpriteRenderer renderer;
    public bool isInteractible;
    bool pickedUpItem;
    public UnityEvent triggerDialogue;
    public UnityEvent triggerInstruction;
    public UnityEvent intoInventory;
    public UnityEvent outInventory;
    public Transform target;

    // Start is called before the first frame update
    void Start()
    {
        renderer = GetComponent<SpriteRenderer>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.Q) && isInteractible) {
            PickedUp();
        }
        else if (Input.GetKey(KeyCode.Tab)) {
            Dropped();
        }
    }

    void OnTriggerEnter2D(Collider2D collision) {
        renderer.color = new Color(1,1,1,0.3f);
        isInteractible = true;
        triggerInstruction.Invoke();
    }

    void OnTriggerExit2D(Collider2D collision) {
        renderer.color = new Color(1,1,1,1);
        isInteractible = false;
        // triggerInstruction.Invoke();
    }

    // there might be an issue if the user tries to pick up more than one object
    void PickedUp() {
        if (isInteractible) {
            isInteractible = false;
            triggerDialogue.Invoke();
            intoInventory.Invoke();
            renderer.enabled = false;
            // disable the item's collision body 
            GetComponent<BoxCollider2D>().enabled = false;
            pickedUpItem = true;
        }
    }

    public void Dropped() {
        //TODO: add a way to drop the object
        if (pickedUpItem) {
            outInventory.Invoke(); // do I even need to have something that removes the item from the ScriptableObject?
            renderer.enabled = true;
            renderer.transform.position = target.position + new Vector3(0,-1,0);
            isInteractible = true;
            pickedUpItem = false;
            GetComponent<BoxCollider2D>().enabled = true;
        }
    }
}
