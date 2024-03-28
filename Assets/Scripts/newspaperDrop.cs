using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Yarn.Unity;

public class newspaperDrop : MonoBehaviour
{
    // Start is called before the first frame update
    public bool isGoodEnd;
    public int count;
    public Inventory GameInventory;
    InMemoryVariableStorage variableStorage;
    // Start is called before the first frame update
    void Start()
    {
        count = 0;
        // inventory = GameObject.FindObjectOfType<Inventory>();
        variableStorage = GameObject.FindObjectOfType<InMemoryVariableStorage>();
        variableStorage.TryGetValue("$secondEnd", out isGoodEnd);
        Debug.Log(GameInventory.newItem);
    }

    // Update is called once per frame
    void Update()
    {
        variableStorage.SetValue("$secondEnd", (count==2));
    }

    void OnTriggerEnter2D(Collider2D collision) {
        if (GameInventory.newItem != null){
            count++;
        } else {
            count--;
        }
    }

    void OnTriggerExit2D(Collider2D collision) {
        if (GameInventory.newItem != null){
            count--;
        } else {
            count++;
        }
    }
}
