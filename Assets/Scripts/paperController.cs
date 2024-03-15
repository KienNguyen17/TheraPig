using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class paperController : MonoBehaviour
{
    public bool isClicked;
    private Camera mainCamera;
    // Start is called before the first frame update
    void Start()
    {
        isClicked = false;
        if (isClicked) {
            Debug.Log("initialized");
        }
        mainCamera = Camera.main;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void OnMouseDrag()
    {
        Vector3 mousePos = Input.mousePosition;
        Vector3 worldPos = mainCamera.ScreenToWorldPoint(mousePos);
        transform.position = new Vector2(worldPos.x, worldPos.y);
        
    }
}
