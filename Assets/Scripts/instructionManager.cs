using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class instructionManager : MonoBehaviour
{
    TMP_Text renderer;
    bool isFluttering = false;

    // Start is called before the first frame update
    void Start()
    {
        renderer = GetComponent<TMP_Text>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void Flutter() {
        if (!isFluttering) {
            renderer.color = new Color(1,1,1,1);
            StartCoroutine(Disable());    
        }
        
    }

    public IEnumerator Disable() {
        isFluttering = true;
        for (float i=1; i>0; i-=0.01f) {
            renderer.color = new Color(1,1,1,i);
            yield return new WaitForSeconds(0.03f);
        }
        isFluttering = false;
    }
}
