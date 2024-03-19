using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerInventoryNEW : MonoBehaviour
{
    public ItemSONEW itemPicked;
    private bool isCollided;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    // if the player collides with the object (triggered the event)

    void OnTriggerEnter2D(Collider2D collision) {
        // if the player collides with the PickableObject, set isCollided to true
        if (collision.gameObject.tag == "PickableObject") {

            // set isCollided to true then
            isCollided = true;

            // if the player clicks "E" while isCollided is true
            if (Input.GetKey(KeyCode.E)) {
                // disable the sprite that has a OnTrigger collision body
                // Add the disabled sprite to the inventory (AddItem)

                // sprite.enabled = false;
                // Debug.Log("Clicked E");
                // itemPicked.AddItem();
            }
            // otherwise do nothing
        }
    }

    void OnTriggerExit2D(Collider2D collision) {
        // When the player leaves the collision space

        // if there is one thing in the inventory
        if (Input.GetKey(KeyCode.F)) {
            // Find the player's current position
            // sprite.transform.position to the player's position
            // enable the sprite (SpriteRenderer)
        }

    }
}
