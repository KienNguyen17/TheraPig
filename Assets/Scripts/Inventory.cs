using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu]

//Changing it to monobehavior instead?
public class Inventory : ScriptableObject
{
    public GameObject newItem;

    public void AddObject(GameObject item) {
        if (newItem != null) {
            // drop (Interaction script)
            newItem.GetComponent<interactive>().Dropped();
        }
        newItem = item;
        // Debug.Log(item.name);
        // Debug.Log(items.Count);
    }

    public void RemoveObject(GameObject item) {
        // items.Remove(item);
        Reset();
    }

    void Reset() {
        newItem = null;
    }
}


