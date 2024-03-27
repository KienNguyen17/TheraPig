using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class spriteSwapper : MonoBehaviour
{
    SpriteRenderer spriteRenderer;
    public Sprite originalSprite;
    public Sprite newSprite;
    bool highlightState;
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
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.Q) && highlightState) {
            triggerDialogue.Invoke();
        }
    }

    void OnTriggerEnter2D()
    {
        ChangeSprite();
        triggerInstruction.Invoke();
    }

    void OnTriggerExit2D()
    {
        ChangeSprite();
    }
}
