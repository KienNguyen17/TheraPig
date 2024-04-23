using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class spriteSwapper : MonoBehaviour
{
    SpriteRenderer spriteRenderer;
    public Sprite originalSprite;
    public Sprite newSprite;
    public bool highlightState;
    public bool isInteractible=false;
    public UnityEvent triggerDialogue;
    public UnityEvent triggerInstruction;

    void ChangeSprite()
    {
        if (highlightState == false)
        {
            spriteRenderer.sprite = newSprite; 
            highlightState = true;
        }
        else
        {
            spriteRenderer.sprite = originalSprite;
            highlightState = false;
        }
    }
    
    // Start is called before the first frame update
    void Start()
    {
        spriteRenderer = gameObject.GetComponent<SpriteRenderer>();
        highlightState = false;
        isInteractible = false;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.Q) && isInteractible) {
            triggerDialogue.Invoke();
        }
    }

    void OnTriggerEnter2D()
    {
        ChangeSprite();
        triggerInstruction.Invoke();
        isInteractible = true;
    }

    void OnTriggerExit2D()
    {
        ChangeSprite();
        isInteractible = false;
    }
}
