using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spriteSwapper : MonoBehaviour
{
    SpriteRenderer spriteRenderer;
    public Sprite originalSprite;
    public Sprite newSprite;
    bool highlightState;

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
    
    }

    void OnTriggerEnter2D()
    {
        ChangeSprite();
    }

    void OnTriggerExit2D()
    {
        ChangeSprite();
    }
}
