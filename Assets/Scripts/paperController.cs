using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Yarn.Unity;

public class paperController : MonoBehaviour
{
    // BoxCollider boxCollider;
    private Vector3 currentMousePos;
    private Vector3 currentPos;
    private Camera mainCamera;
    private Vector3 objPos;
    private bool isInteracted;
    // Start is called before the first frame update
    void Start()
    {
        mainCamera = Camera.main;
        isInteracted = false;
    }

    // Update is called once per frame
    void Update()
    {

    }

    void OnMouseDown() 
    {
        if (isInteracted) 
        {
            currentMousePos = mainCamera.ScreenToWorldPoint(Input.mousePosition);
            currentPos = transform.position;
        }
    }

    void OnMouseDrag()
    {
        if (isInteracted) 
        {
            Vector3 mousePos = mainCamera.ScreenToWorldPoint(Input.mousePosition);
            transform.position = new Vector3(currentPos.x+mousePos.x-currentMousePos.x, currentPos.y+mousePos.y-currentMousePos.y, currentPos.z);
        }
    }
        

    public void DisableControl() 
    {
        isInteracted = false;
    }

    public void EnableControl() 
    {
        isInteracted = true;
    }
}
