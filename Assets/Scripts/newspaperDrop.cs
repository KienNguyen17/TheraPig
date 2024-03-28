using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Yarn.Unity;

public class newspaperDrop : MonoBehaviour
{
    // Start is called before the first frame update
    public bool isGoodEnd;
    InMemoryVariableStorage variableStorage;
    // Start is called before the first frame update
    void Start()
    {
        variableStorage = GameObject.FindObjectOfType<InMemoryVariableStorage>();
        variableStorage.TryGetValue("$secondEnd", out isGoodEnd);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnTriggerStay2D(Collider2D collision) {
        if(collision.GetComponent<Collider2D>().CompareTag("Newspaper")){
            isGoodEnd = true;
            variableStorage.SetValue("$secondEnd", isGoodEnd);
        }
    }

    // void OnTriggerExit2D(Collider2D collision) {
    //     if(collision.GetComponent<Collider2D>().CompareTag("Newspaper")){
    //         isGoodEnd = false;
    //     }
    // }
}
