using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class instructionManager : MonoBehaviour
{
    TMP_Text renderer;
    // Start is called before the first frame update
    void Start()
    {
        renderer = GetComponent<TMP_Text>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void ToggleActive() {
        renderer.enabled = !renderer.enabled;
    }

}
