using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Inventory : MonoBehaviour
{
    public ItemSO itemScriptableObject;
    [SerializeField] Image iconImage;

    // Update is called once per frame
    void Update()
    {
        iconImage.sprite = itemScriptableObject.icon;
    }
}
