using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu]
public class Inventory : ScriptableObject
{
    public List<GameObject> items = new();

    public void AddObject(GameObject item) {
        items.Add(item);
        Debug.Log(item.name);
        Debug.Log(items.Count);
    }

    public void RemoveObject(GameObject item) {
        items.Remove(item);
    }

    void Reset() {
        items.Clear();
    }
}


