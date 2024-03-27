using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class PopUpEvent : MonoBehaviour
{
    public UnityEvent triggerPopUp;
    public UnityEvent disablePopUp;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnTriggerEnter2D()
    {
        triggerPopUp.Invoke();
    }

    void OnTriggerExit2D()
    {
        disablePopUp.Invoke();
    }
}
