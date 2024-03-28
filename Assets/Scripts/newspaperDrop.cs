using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Yarn.Unity;

public class newspaperDrop : MonoBehaviour
{
    // Start is called before the first frame update
    public bool isGoodEnd;
    public int count;
    Inventory inventory;
    InMemoryVariableStorage variableStorage;
    // Start is called before the first frame update
    void Start()
    {
        count = 0;
        inventory = GameObject.FindObjectOfType<Inventory>();
        variableStorage = GameObject.FindObjectOfType<InMemoryVariableStorage>();
        variableStorage.TryGetValue("$secondEnd", out isGoodEnd);
    }

    // Update is called once per frame
    void Update()
    {
        variableStorage.SetValue("$secondEnd", (count==2));
    }

    void OnTriggerStay2D(Collider2D collision) {
        if (inventory.newItem != null){
            count++;
        } else {
            count--;
        }
    }

    void OnTriggerExit2D(Collider2D collision) {
        if (inventory.newItem != null){
            count--;
        } else {
            count++;
        }
    }
}
