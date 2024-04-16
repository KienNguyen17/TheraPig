using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Yarn.Unity;

public class paperController : MonoBehaviour
{
    // BoxCollider boxCollider;
    private Vector3 currentMousePos;
    private Vector3 currentPos;
    public Camera currentCamera;
    private Vector3 objPos;
    private bool isInteracted;
    // Start is called before the first frame update
    void Start()
    {
        isInteracted = true;
    }

    // Update is called once per frame
    void Update()
    {

    }

    void OnMouseDown() 
    {
        if (isInteracted) 
        {
            currentMousePos = currentCamera.ScreenToWorldPoint(Input.mousePosition);
            currentPos = transform.position;
        }
    }

    void OnMouseDrag()
    {
        if (isInteracted) 
        {
            Vector3 mousePos = currentCamera.ScreenToWorldPoint(Input.mousePosition);
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
